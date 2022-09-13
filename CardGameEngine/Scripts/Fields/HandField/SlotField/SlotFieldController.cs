using UnityEngine;

namespace Field.Hand.Slot
{
    public class SlotFieldController : MonoBehaviour, ISlotFieldController
    {
        [Header("Parent slot reference for the card.")]
        [Space]
        [SerializeField] Transform _parentForSlotCard;
        public Transform ParentForSlotCard => _parentForSlotCard;

        // Checks if slot is free.
        public bool IsThereAnySlotFree
        {
            get
            {
                return _getChildNumber() >= 1 ? false : true;
            }
        }

        private int _getChildNumber() => _parentForSlotCard.childCount;
    }
}
