using UnityEngine;

using Common.Inteface;
using Common.Enum;
using Common.TurnPhase;

namespace Card
{
    [RequireComponent(typeof(CardMovement))]
    public abstract class Card : MonoBehaviour, ICard, IOnTurnPhaseChangeHandler
    {
        public static ICardsManager CardsManager => GameObject.Find("GameManager").GetComponentInChildren<ICardsManager>();

        private bool _canCardMove = false;
        private EFieldType _cardCurrentField;

        #region ICard implementation
        public bool CanCardMove() => _canCardMove;
        public EFieldType GetCardCurrentField() => _cardCurrentField;
        public void SetCardCurrentField(EFieldType field)
        {
            _cardCurrentField = field;
        }
        public void DiscardCard()
        {
            GameObject.Destroy(this.gameObject);
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
            if(currenTurnPhase == ETurnPhase.Place)
            {
                _canCardMove = true;
                return;
            }
            _canCardMove = false;
        }

        #endregion

    }
}
