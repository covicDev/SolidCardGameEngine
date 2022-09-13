using UnityEngine;

namespace Field.Hand
{
    public interface IHandFieldController
    {
        void TransferCard(Transform card);
        bool CheckIfThereAnyFreeSlot();
    }
}