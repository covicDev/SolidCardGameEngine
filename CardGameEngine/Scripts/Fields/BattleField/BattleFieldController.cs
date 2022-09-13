using UnityEngine;

using Common.Log;
using Common.Enum;
using Common.TurnPhase;
using Card.Creature;

namespace Field.Battle
{
    [RequireComponent(typeof(IBattleFieldReferences))]
    public class BattleFieldController : Field, IBattleFieldController, IOnTurnPhaseChangeHandler
    {
        private IBattleFieldReferences _battleFieldReferences;

        private void Awake()
        {
            _battleFieldReferences = GetComponent<IBattleFieldReferences>();
        }

        public bool CheckIfCardCanBeTransfered()
        {
            if (base.GetCurrentTurnPhase() != ETurnPhase.Place)
            {
                LogFieldController.ShowMessage("This is not 'Place' turn's phase!");
                return false;
            }
            if(_battleFieldReferences.OnBattleFieldCardsParent.childCount > 0)
            {
                LogFieldController.ShowMessage("This is a creature on battlefield already!");
                return false;
            }
            return true;
        }

        public override void TransferCard(Transform card)
        {
            var parentForCard = _battleFieldReferences.OnBattleFieldCardsParent;

            card.SetParent(parentForCard);
            card.position = parentForCard.position;

            LogFieldController.ShowMessage("Creature card was transfered to battlefield.");
        }

        public void OrderCreatureCardToAttack()
        {
            if (_battleFieldReferences.OnBattleFieldCardsParent.childCount <= 0)
            {
                LogFieldController.ShowMessage("This is a no creature on battlefield!");
                return;
            }

            var creatureCardController = _battleFieldReferences.OnBattleFieldCardsParent.GetComponentInChildren<ICreatureCardController>();
            creatureCardController.OrderToAttack();
        }

        public new void OnChangeTurnPhase(ETurnPhase currenTurnPhase)
        {
            base.OnChangeTurnPhase(currenTurnPhase);
            if (currenTurnPhase == ETurnPhase.Attack)
            OrderCreatureCardToAttack();
        }
    }
}
