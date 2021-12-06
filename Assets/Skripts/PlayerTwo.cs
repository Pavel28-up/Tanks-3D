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

        private Rigidbody _rigidbody;

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
                player.transform.position += player.transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                player.transform.position -= player.transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                player.transform.Rotate(0, _rotationspeed, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player.transform.Rotate(0, _rotationspeed * -1, 0);
            }
        }
    }
}
