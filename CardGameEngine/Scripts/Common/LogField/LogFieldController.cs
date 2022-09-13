using System;
using UnityEngine;
using UnityEngine.UI;

using Common.Enum;
using Common.TurnPhase;

namespace Common.Log
{
    public class LogFieldController : MonoBehaviour, IOnTurnPhaseChangeHandler
    {
        [SerializeField] Text _logLineReference;
        [SerializeField] Text _phaseLineReference;

        private static Text _logLine;
        private static Text _phaseLine;
       
        private void Awake()
        {
            _logLine = _logLineReference;
            _phaseLine = _phaseLineReference;
        }

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
            _phaseLine.text = $"Current turn phase: {currenTurnPhase.ToString()}";

            if (currenTurnPhase == ETurnPhase.EntTurn) _logLine.text = "";
        }

        public static void ShowMessage(string message)
        {
            
            _logLine.text = $"{message}\n(at {DateTime.Now})";
        }

    }
}
