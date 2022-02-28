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

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) StartCoroutine("SpawnField");
        }

        private IEnumerator SpawnField()
        {
            int _spawnCount = 400;

            while (_spawnCount > 0)
            {
                _spawnCount--;

                Vector3 _position = new Vector3(Random.Range(_spawnPoint.position.x - _volume.x, _spawnPoint.position.x + _volume.x),
                _spawnPoint.position.y,
                Random.Range(_spawnPoint.position.z - _volume.z, _spawnPoint.position.z + _volume.z));

                _checkCollision = CheckSpawnPoint(_position);
                Debug.Log(_checkCollision);

                if (_checkCollision)
                {
                    int _rand = Random.Range(0, _prefab.Length - 1);
                    GameObject _object = Instantiate(_prefab[_rand], _position, Quaternion.identity);
                    Destroy(_object, 100);
                    yield return new WaitForSeconds(_spawnDelay);
                }
                else
                {
                    SpawnField();
                }
            }
        }

        private bool CheckSpawnPoint(Vector3 _position)
        {
            _colliders = Physics.OverlapBox(_position, _sizeCollider);

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
