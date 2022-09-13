using UnityEngine;

namespace Field.Battle
{
    public interface IBattleFieldController
    {
        bool CheckIfCardCanBeTransfered();
        void TransferCard(Transform card);
        void OrderCreatureCardToAttack();
    }
}