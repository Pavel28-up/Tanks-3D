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

        private float vertical;
        private float horizontal;
        private Rigidbody _rigidbody;
        [HideInInspector]
        public bool _life = true;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");

            Fire();
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(vertical * _speed * transform.forward);
            _rigidbody.transform.Rotate(0, horizontal * _rotationspeed, 0);
        }

        public void Fire()
        {
            if (Input.GetButtonDown("FireProjectilePlayerOne"))
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

        public void OnDie()
        {
             _life = false;
            Debug.Log("You Die");
        }
    }
}
