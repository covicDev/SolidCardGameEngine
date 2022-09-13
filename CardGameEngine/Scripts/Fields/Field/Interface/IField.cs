using UnityEngine;

using Common.Enum;

namespace Field
{
    public interface IField
    {
        IFieldsManager FieldManager { get; }
        ETurnPhase GetCurrentTurnPhase();
        void TransferCard(Transform card);
        void InjectFieldManagerReference(IFieldsManager fieldManager);
    }
}