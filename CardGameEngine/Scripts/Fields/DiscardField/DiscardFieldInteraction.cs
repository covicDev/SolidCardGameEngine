using UnityEngine;
using UnityEngine.EventSystems;

using Common.Log;
using Common.Struct;
using Common.Enum;

namespace Field.Discard
{
    [RequireComponent(typeof(IDiscardFieldController))]
    public class DiscardFieldInteraction : MonoBehaviour, IDropHandler
    {
        private IDiscardFieldController _discardFieldController;

        private void Awake()
        {
            _discardFieldController = GetComponent<IDiscardFieldController>();
        }

        #region IDropHandler implementation
        public void OnDrop(PointerEventData eventData)
        {
            if (eventData?.pointerDrag == null) return;
            
            var item = eventData.pointerDrag;

            // Interaction with creature card. 
            if (item.CompareTag(STagNames.TagCreatureName))
            {
                if (_discardFieldController.CheckIfCardCanBeTransfered() == false) return;

                _discardFieldController.TransferCard(item.transform);
                return;
            }
        }

        #endregion
    }
}
