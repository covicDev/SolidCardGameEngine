using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using Field.Hand.Slot;

namespace Field.Hand
{
    [RequireComponent(typeof(IHandFieldReferences))]
    public class HandFieldController : Field, IHandFieldController
    {
        private IHandFieldReferences _handFieldReferences;
        private List<ISlotFieldController> _freeSlotList
        {
            get
            {
                var slots = _handFieldReferences.SlotFieldControllerReferences;
                var freeslot = from item in slots where item.IsThereAnySlotFree == true select item;
                return freeslot.ToList<ISlotFieldController>();
            }

        }
        private ISlotFieldController _getFreeSlotFieldReference() => _freeSlotList.FirstOrDefault();

        private void Awake()
        {
            _handFieldReferences = GetComponent<IHandFieldReferences>();
        }

        #region IHandFieldController implementation
        public override void TransferCard(Transform card)
        {
            var parentForCard = _getFreeSlotFieldReference().ParentForSlotCard;
            card.SetParent(parentForCard);
            card.position = parentForCard.position;
        }

        public bool CheckIfThereAnyFreeSlot()
        {
            return _freeSlotList.Count() > 0 ? true : false;
        }

        #endregion
    }
}

