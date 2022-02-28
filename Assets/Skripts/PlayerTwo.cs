using UnityEngine;

namespace Skripts
{
    public class PlayerTwo : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationspeed;
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject Projectile;
        [SerializeField] private GameObject StartSpawn;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Fire();
        }

        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rigidbody.AddForce(transform.forward * _speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _rigidbody.AddForce(transform.forward * _speed * -1);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _rigidbody.transform.Rotate(0, _rotationspeed, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _rigidbody.transform.Rotate(0, _rotationspeed * -1, 0);
            }
        }

        void Fire()
        {
            if (Input.GetKeyUp(KeyCode.Keypad0))
            {
                Vector3 SpawnPoint = StartSpawn.transform.position;
                Quaternion SpawmRotation = StartSpawn.transform.rotation;
                GameObject ProjectileForFire = Instantiate(Projectile, SpawnPoint, SpawmRotation) as GameObject;

                Rigidbody Run = ProjectileForFire.GetComponent<Rigidbody>();
                Run.AddForce(ProjectileForFire.transform.forward * 10, ForceMode.Impulse);

                Destroy(ProjectileForFire, 5);
            }
        }
    }
}
