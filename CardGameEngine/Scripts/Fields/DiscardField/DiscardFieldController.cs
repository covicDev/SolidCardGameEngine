using UnityEngine;

using Common.Inteface;
using Common.Enum;
using Common.Log;

namespace Field.Discard
{
    public class DiscardFieldController : Field, IDiscardFieldController
    {
        public override void TransferCard(Transform card)
        {
            base.TransferCard(card);

            var controller = card.GetComponent<ICard>();
            controller.SetCardCurrentField(EFieldType.Discard);
            controller.DiscardCard();

            LogFieldController.ShowMessage("Creature card was discarded.");
        }

        public bool CheckIfCardCanBeTransfered()
        {
            return base.GetCurrentTurnPhase() == ETurnPhase.Place;
        }
    }
}
