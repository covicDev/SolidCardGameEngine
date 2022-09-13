using UnityEngine;
using UnityEngine.EventSystems;

namespace Field.Pile
{
    [RequireComponent(typeof(IPileFieldController))]
    public class PileFieldInteraction : MonoBehaviour, IPointerClickHandler
    {
        private IPileFieldController _pileFieldController;

        private void Awake()
        {
            _pileFieldController = GetComponent<IPileFieldController>();
        }

        // Handler implementation.
        public void OnPointerClick(PointerEventData eventData)
        {
            _pileFieldController.GetNextCard();
        }
    }
}
