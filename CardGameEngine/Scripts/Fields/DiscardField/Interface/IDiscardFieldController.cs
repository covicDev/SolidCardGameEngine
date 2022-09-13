using UnityEngine;

namespace Field.Discard
{
    public interface IDiscardFieldController
    {
        bool CheckIfCardCanBeTransfered();
        void TransferCard(Transform card);
    }
}