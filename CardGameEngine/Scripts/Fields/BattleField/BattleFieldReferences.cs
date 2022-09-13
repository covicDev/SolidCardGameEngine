using UnityEngine;

namespace Field.Battle
{
    public class BattleFieldReferences : MonoBehaviour, IBattleFieldReferences
    {
        [Header("Parent reference of cards on battle field.")]
        [Space()]
        [SerializeField] Transform _onBattleFieldCardsParent;
        public Transform OnBattleFieldCardsParent => _onBattleFieldCardsParent;
    }
}
