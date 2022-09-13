using UnityEngine;

using Common.Enum;
using Common.Log;

namespace Field.Pile
{
    public class PileFieldController : Field, IPileFieldController
    {

        #region IPileFieldController implementation
        public void GetNextCard()
        {
            if (CheckConditionsToPassDrawCard() == false) return;

            var creatureCardGameObject = _getCreaturePrefabInstantiate();
            base.FieldManager.HandFieldControllerReference.TransferCard(creatureCardGameObject.transform);

            LogFieldController.ShowMessage("Draw card action was done.");
        }

        #endregion

        #region Private methods
        private bool CheckConditionsToPassDrawCard()
        {
            if (base.GetCurrentTurnPhase() != ETurnPhase.Draw)
            {
                LogFieldController.ShowMessage("This is not 'Draw' turn's phase!");
                return false;
            }
            if (base.FieldManager.HandFieldControllerReference.CheckIfThereAnyFreeSlot() == false)
            {
                LogFieldController.ShowMessage("There are no free slots on hand!");
                return false;
            }
            return true;
        }

        private GameObject _getCreaturePrefabInstantiate()
        {
            var creatureCardPrefab = base.FieldManager.CreatureCardPrefab;
            var creatureCardGameObject = Instantiate(creatureCardPrefab);
            return creatureCardGameObject;
        }

        #endregion

    }
}
