using UnityEngine;

using Card.Scriptable;
using Common.Log;

namespace Card.Creature
{
    public class CreatureCardController : Card, ICreatureCardController
    {
        #region Variable
        private ICreatureCardReferences _cardCreatureReference;
        private CreatureCardData _creatureCardData;

        #endregion

        private void Awake()
        {
            _cardCreatureReference = GetComponentInChildren<ICreatureCardReferences>();
        }

        private void Start()
        {
            _prepareCreatureCard();
        }

        #region ICreatureCardController implementation
        public void OrderToAttack()
        {
            LogFieldController.ShowMessage($"The creature has attacked, {_creatureCardData.Attack} damage was given.");
        }

        #endregion

        #region Private method

        /// <summary>
        /// Prepare and assign creatures graphic stats values.
        /// </summary>
        private void _prepareCreatureCard()
        {
            
            _creatureCardData = Card.CardsManager.GetNextCreatureCardData();

            // Set graphics.
            _cardCreatureReference.PortraitReference.sprite = _creatureCardData.Portrait;
            _cardCreatureReference.NameTextReference.text = _creatureCardData.name;
            _cardCreatureReference.LifeTextReference.text = _creatureCardData.Life.ToString();
            _cardCreatureReference.AttackTextReference.text = _creatureCardData.Attack.ToString();
        }

        #endregion
    }
}
