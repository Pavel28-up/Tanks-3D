using UnityEngine;

namespace Skripts
{
    public class PlayerOne : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationspeed;

        public GameObject player;
        public GameObject Projectile;
        public GameObject StartSpawn;

        public Rigidbody _rigidbody;

        public float vertical;
        public float horizontal;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Fire()
        {
            if (Input.GetButtonUp("FireProjectilePlayerOne"))
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

            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");

            _rigidbody.AddForce((transform.forward * vertical) * _speed / Time.deltaTime);
            _rigidbody.transform.Rotate(0, horizontal * _rotationspeed, 0);
        }
    }
}
