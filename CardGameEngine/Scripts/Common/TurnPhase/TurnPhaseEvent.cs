using System.Collections.Generic;

using Common.Enum;

namespace Common.TurnPhase
{
    public static class TurnPhaseEvent
    {
        public static ETurnPhase CurrentTurnPhase = ETurnPhase.Null;

        private static List<IOnTurnPhaseChangeHandler> _observers = new List<IOnTurnPhaseChangeHandler>();

        public static void Attach(IOnTurnPhaseChangeHandler observer)
        {
            _observers.Add(observer);
        }

        public static void Detach(IOnTurnPhaseChangeHandler observer)
        {
            _observers.Remove(observer);
        }

        public static void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.OnChangeTurnPhase(CurrentTurnPhase);
            }
        }
    }
}
