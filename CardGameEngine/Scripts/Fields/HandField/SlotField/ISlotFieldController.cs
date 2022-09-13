using UnityEngine;

namespace Field.Hand.Slot
{
    public interface ISlotFieldController
    {
        bool IsThereAnySlotFree { get; }
        Transform ParentForSlotCard { get; }
    }
}