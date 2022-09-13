using System.Collections.Generic;
using UnityEngine;

using Card.Scriptable;

namespace Card
{
    public interface ICardsManager
    {
        List<CreatureCardData> CreatureCardData { get; }
        Camera CameraMain { get; }
        CreatureCardData GetNextCreatureCardData();
    }
}