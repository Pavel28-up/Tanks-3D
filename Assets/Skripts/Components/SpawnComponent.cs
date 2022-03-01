using UnityEngine;

namespace Skripts.Components
{
    public class SpawnComponent : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Transform _target1;
        [SerializeField] private Transform _target2;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private GameObject _prefab1;
        [SerializeField] private GameObject _prefab2;


        [ContextMenu("Spawn")]
        public void Spawn()
        {
            _prefab.SetActive(true);
            _prefab1.SetActive(true);
            _prefab2.SetActive(true);
        }
    }
}