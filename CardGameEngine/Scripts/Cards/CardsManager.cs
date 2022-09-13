using System.Collections.Generic;
using UnityEngine;

using Card.Scriptable;

namespace Card
{
    public class CardsManager : MonoBehaviour, ICardsManager
    {
        #region Variables

        [Header("Table of creatures data (Scriptable).")]
        [SerializeField] private List<CreatureCardData> _creatureCardData;

        private List<CreatureCardData> _creatureCardDataClone = new List<CreatureCardData>();
        public List<CreatureCardData> CreatureCardData => _creatureCardDataClone;

        // Main camera reference.
        private Camera _cameraMain;
        public Camera CameraMain => _cameraMain;

        #endregion

        private void Awake()
        {
            _cameraMain = Camera.main;

            foreach (var item in _creatureCardData)
            {
                _creatureCardDataClone.Add(Instantiate(item));
            }
        }

        public CreatureCardData GetNextCreatureCardData()
        {
            int index = Random.Range(0, CreatureCardData.Count);
            return CreatureCardData[index];
        }
    }
}
