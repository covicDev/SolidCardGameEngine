using Common.Enum;

namespace Common.TurnPhase
{
    public interface IOnTurnPhaseChangeHandler
    {
        void OnChangeTurnPhase(ETurnPhase currenTurnPhase);
    }
}

