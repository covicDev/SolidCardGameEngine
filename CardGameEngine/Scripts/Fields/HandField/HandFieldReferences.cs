using System.Collections.Generic;
using UnityEngine;

using Field.Hand.Slot;

namespace Field.Hand
{
    public class HandFieldReferences : MonoBehaviour, IHandFieldReferences
    {
        [Header("References to hand's slots.")]
        [Space()]
        [SerializeField] List<SlotFieldController> _slotFieldControllerReferences;
        public List<SlotFieldController> SlotFieldControllerReferences => _slotFieldControllerReferences;
    }
}
