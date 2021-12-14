using UnityEngine;

namespace Skripts
{
    public class PlayerTwo : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationspeed;

        public GameObject player;
        public GameObject Projectile;
        public GameObject StartSpawn;

        public Rigidbody _rigidbody;

        public float vertical;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
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

        private void Update()
        {
            Fire();

            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rigidbody.AddForce(transform.forward * _speed / Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _rigidbody.AddForce(transform.forward * _speed / Time.deltaTime * -1);
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
    }
}
