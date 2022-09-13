using UnityEngine;

using Common.Enum;

namespace Common.TurnPhase
{
    public class TurnPhaseController : MonoBehaviour
    {
        public void OnDrawCardPhaseClick()
        {
            TurnPhaseEvent.CurrentTurnPhase = ETurnPhase.Draw;
            TurnPhaseEvent.Notify();
        }
        public void OnPlaceCardPhaseClick()
        {
            TurnPhaseEvent.CurrentTurnPhase = ETurnPhase.Place;
            TurnPhaseEvent.Notify();
        }
        public void OnAttackPhaseClick()
        {
            TurnPhaseEvent.CurrentTurnPhase = ETurnPhase.Attack;
            TurnPhaseEvent.Notify();
        }
        public void OnEndTrunPhaseClick()
        {
            TurnPhaseEvent.CurrentTurnPhase = ETurnPhase.EntTurn;
            TurnPhaseEvent.Notify();
        }

    }
}
