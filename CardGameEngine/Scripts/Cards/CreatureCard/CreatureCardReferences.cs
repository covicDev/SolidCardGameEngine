using UnityEngine;
using UnityEngine.UI;

namespace Card.Creature
{
    public class CreatureCardReferences : MonoBehaviour, ICreatureCardReferences
    {
        [SerializeField] Image _portrait;
        public Image PortraitReference => _portrait;

        [SerializeField] Text _nameText;
        public Text NameTextReference => _nameText;

        [SerializeField] Text _lifeText;
        public Text LifeTextReference => _lifeText;

        [SerializeField] Text _attackText;
        public Text AttackTextReference => _attackText;
    }
}
