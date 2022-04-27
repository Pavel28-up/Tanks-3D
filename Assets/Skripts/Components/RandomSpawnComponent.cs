using System.Collections;
using UnityEngine;

namespace Skripts.Components
{
    public class RandomSpawnComponent : MonoBehaviour
    {
        [SerializeField] private float _spawnDelay;
        [SerializeField] private GameObject[] _prefab;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Vector3 _volume;

        private Vector3 _sizeCollider = new Vector3(0.25f, 0.25f, 0.25f);
        private Collider[] _colliders;
        private bool _checkCollision;
        private PlayerOne _playerOne;

        public void Awake()
        {
            _playerOne = FindObjectOfType<PlayerOne>();
            StartCoroutine(SpawnField());
        }

        private IEnumerator SpawnField()
        {
            while (_playerOne._life)
            {
                Vector3 position = new Vector3(Random.Range(_spawnPoint.position.x - _volume.x, _spawnPoint.position.x + _volume.x),
                _spawnPoint.position.y,
                Random.Range(_spawnPoint.position.z - _volume.z, _spawnPoint.position.z + _volume.z));

                _checkCollision = CheckSpawnPoint(position);

                if (_checkCollision)
                {
                    int rand = Random.Range(0, _prefab.Length);
                    GameObject _object = Instantiate(_prefab[rand], position, Quaternion.identity);
                    Destroy(_object, 15);
                    yield return new WaitForSeconds(_spawnDelay);
                }
                else
                {
                    yield return null;
                }
            }
        }

        private bool CheckSpawnPoint(Vector3 position)
        {
            _colliders = Physics.OverlapBox(position, _sizeCollider);

            if (_colliders.Length > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
