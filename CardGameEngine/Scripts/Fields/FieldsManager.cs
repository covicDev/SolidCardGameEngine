using UnityEngine;

using Field.Pile;
using Field.Hand;
using Field.Battle;

namespace Field
{
    public class FieldsManager : MonoBehaviour, IFieldsManager
    {
        #region Pile field variables
        [Header("Pile field reference.")]
        [Space()]
        [SerializeField] GameObject _pileFieldReference;
        public GameObject PileFieldReference => _pileFieldReference;

        private IPileFieldController _pileFieldControllerReference;
        public IPileFieldController PileFieldControllerReference => _pileFieldControllerReference;

        #endregion

        #region Hand field variables
        [Header("Hand field reference.")]
        [Space()]
        [SerializeField] GameObject _handFieldReference;
        public GameObject HandFieldReference => _handFieldReference;

        private IHandFieldController _handFieldControllerReference;
        public IHandFieldController HandFieldControllerReference => _handFieldControllerReference;

        #endregion

        #region Battle field variables
        [Header("Battle field reference.")]
        [Space()]
        [SerializeField] GameObject _battleFieldReference;
        public GameObject BattleFieldReference => _battleFieldReference;

        private IBattleFieldController _battleFieldControllerReference;
        public IBattleFieldController BattleFieldControllerReference => _battleFieldControllerReference;

        #endregion

        #region Prefabs references.
        [Header("Creature card reference.")]
        [Space()]
        [SerializeField] GameObject _creatureCardPrefab;
        public GameObject CreatureCardPrefab => _creatureCardPrefab;

        #endregion

        private void Awake()
        {
            _pileFieldControllerReference = _pileFieldReference.GetComponent<IPileFieldController>();
            _handFieldControllerReference = _handFieldReference.GetComponent<IHandFieldController>();
            _battleFieldControllerReference = _battleFieldReference.GetComponent<IBattleFieldController>();
        }

        private void Start()
        {
            _pileFieldReference.GetComponent<IField>().InjectFieldManagerReference(this);
            _handFieldReference.GetComponent<IField>().InjectFieldManagerReference(this);
            _battleFieldReference.GetComponent<IField>().InjectFieldManagerReference(this);
        }
    }
}
