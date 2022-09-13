using Common.Enum;

namespace Common.Inteface
{
    public interface ICard
    {
        bool CanCardMove();
        EFieldType GetCardCurrentField();
        void SetCardCurrentField(EFieldType field);
        void DiscardCard();
    }
}

