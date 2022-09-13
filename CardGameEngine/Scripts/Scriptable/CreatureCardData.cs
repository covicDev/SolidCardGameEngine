using UnityEngine;

namespace Card.Scriptable
{
    [CreateAssetMenu(fileName = "NewCreatureName", menuName = "NewCreatureCard")]
    public class CreatureCardData : ScriptableObject
    {
        public new string name;

        [Header("Creature card portrait.")]
        public Sprite Portrait;

        [Header("Creature card stats.")]
        public int Life;
        public int Attack;
    }
}