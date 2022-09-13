using UnityEngine.UI;

namespace Card.Creature
{
    public interface ICreatureCardReferences
    {
        Image PortraitReference { get; }
        Text NameTextReference { get; }
        Text LifeTextReference { get; }
        Text AttackTextReference { get; }
    }
}


