using UnityEngine;
using UnityEngine.EventSystems;

using Common.Struct;

namespace Field.Battle
{
    [RequireComponent(typeof(IBattleFieldController))]
    public class BattleFieldInteraction : MonoBehaviour, IDropHandler
    {
        private IBattleFieldController _battleFieldController;

        private void Awake()
        {
            _battleFieldController = GetComponent<IBattleFieldController>();
        }

        public void OnDrop(PointerEventData eventData)
        {
            if (eventData?.pointerDrag == null) return;

            var item = eventData.pointerDrag;

            // Interaction with creature card. 
            if (item.CompareTag(STagNames.TagCreatureName))
            {
                // Checks if card can be transfered to this field.
                if (_battleFieldController.CheckIfCardCanBeTransfered() == false) return;
                
                // Transfer card to battlefield.
                _battleFieldController.TransferCard(item.transform);
            }
        }
    }
}
