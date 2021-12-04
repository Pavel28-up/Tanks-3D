using UnityEngine;

namespace Skripts
{
    public class PlayerOne : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationspeed;

        private Vector2 _direction;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void SetDirection(Vector2 direction)
        {
            _direction = direction;
        }
        private void FixedUpdate()
        {
            _rigidbody.velocity = new Vector2(_direction.x * _speed, _rigidbody.velocity.y);
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.5f);
        }
    }
}
