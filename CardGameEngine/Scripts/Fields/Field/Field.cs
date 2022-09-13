using UnityEngine;

using Common.TurnPhase;
using Common.Enum;

namespace Field
{
    public abstract class Field : MonoBehaviour, IField, IOnTurnPhaseChangeHandler
    {
        protected ETurnPhase _currentTurnPhase;
        private IFieldsManager _fieldsManager;

        #region IField implementation
        public IFieldsManager FieldManager => _fieldsManager;
        public ETurnPhase GetCurrentTurnPhase() => _currentTurnPhase;
        public virtual void TransferCard(Transform card)
        {
            card.SetParent(transform);
            card.position = transform.position;
        }
        public void InjectFieldManagerReference(IFieldsManager fieldManager)
        {
            _fieldsManager = fieldManager;
        }

        #endregion

        #region IOnTurnPhaseChangeHandler implementation
        private void OnEnable()
        {
            TurnPhaseEvent.Attach(this);
        }
        private void OnDisable()
        {
            TurnPhaseEvent.Detach(this);
        }
        public void OnChangeTurnPhase(ETurnPhase currenTurnPhase)
        {
            _currentTurnPhase = currenTurnPhase;
        }

        #endregion
    }
}