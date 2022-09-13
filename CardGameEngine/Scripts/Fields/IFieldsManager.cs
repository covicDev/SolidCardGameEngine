using UnityEngine;

using Field.Hand;

namespace Field
{
    public interface IFieldsManager
    {
        GameObject PileFieldReference { get; }
        GameObject HandFieldReference { get; }
        IHandFieldController HandFieldControllerReference { get; }
        GameObject CreatureCardPrefab { get; }
    }
}