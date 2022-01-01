using UnityEngine;
using System.Collections;

namespace Skripts
{
    public class PlayerOne : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationspeed;

        public GameObject player;
        public GameObject Projectile;
        public GameObject StartSpawn;
        public GameObject _gun;


        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Fire()
        {
            if (Input.GetButtonUp("FireProjectilePlayerOne"))
            {
                if (_gun) 
                {
                    Ray ray = new Ray(transform.position, transform.forward);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        GameObject hitObject = hit.transform.gameObject;
                        ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                        if (target != null) 
                        {
                            target.ReactToHit();
                            Vector3 SpawnPoint = StartSpawn.transform.position;
                            Quaternion SpawmRotation = StartSpawn.transform.rotation;
                            GameObject ProjectileForFire = Instantiate(Projectile, SpawnPoint, SpawmRotation) as GameObject;

                            Rigidbody Run = ProjectileForFire.GetComponent<Rigidbody>();
                            Run.AddForce(ProjectileForFire.transform.forward * 10, ForceMode.Impulse);

                            Destroy(ProjectileForFire, 5);
                        }
                        else
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
        }

        private void Update()
        {
            Fire();

            if (Input.GetKey(KeyCode.W))
            {
                player.transform.position += player.transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.S))
            { 
                player.transform.position -= player.transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.transform.Rotate(0, _rotationspeed, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                player.transform.Rotate(0, _rotationspeed * -1, 0);
            }
        }
    }
}
