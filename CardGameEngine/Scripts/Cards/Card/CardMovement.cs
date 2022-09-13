using UnityEngine;
using UnityEngine.EventSystems;

using Common.Inteface;
using Common.Enum;

namespace Card
{
    [RequireComponent(typeof(CanvasGroup))]
    [RequireComponent(typeof(ICard))]
    public class CardMovement : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        #region Variables
        private ICard _cardController;

        private Camera _camera;
        private CanvasGroup _canvasGroup;

        EFieldType _fieldTypeBeforeBeginDrag = EFieldType.Null;

        #endregion

        private void Awake()
        {
            _cardController = GetComponent<ICard>();
            
            _camera = Card.CardsManager.CameraMain;
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (_cardController.CanCardMove() == false) return;

            _canvasGroup.blocksRaycasts = false;
            if (Input.GetMouseButton(0))
            {
                _fieldTypeBeforeBeginDrag = _cardController.GetCardCurrentField();
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (_cardController.CanCardMove() == false) return;
            if (eventData?.pointerDrag == null) return;

            if (Input.GetMouseButton(0))
            {
                var data = _camera.ScreenToWorldPoint(Input.mousePosition);
                data.z = 0f;
                this.transform.position = data;
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (_cardController.CanCardMove() == false) return;

            _canvasGroup.blocksRaycasts = true;
            if (_fieldTypeBeforeBeginDrag == _cardController.GetCardCurrentField())
            {
                transform.position = transform.parent.position;
            }
        }
    }
}
