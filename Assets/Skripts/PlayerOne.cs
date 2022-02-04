using UnityEngine;

namespace Skripts
{
    public class PlayerOne : MonoBehaviour
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

            var vertical = Input.GetAxis("Vertical");
            var horizontal = Input.GetAxis("Horizontal");

            _rigidbody.AddForce((transform.forward * vertical) * _speed / Time.deltaTime);
            _rigidbody.transform.Rotate(0, horizontal * _rotationspeed, 0);
        }

        public void Fire()
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

        public void TakeHPDamage()
        {
            Debug.Log("-1 HP");
        }

        public void TakeArmorDamage()
        {
            Debug.Log("-1 Armor");
        }
    }
}
