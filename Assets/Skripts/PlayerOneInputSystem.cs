using UnityEngine;
using UnityEngine.InputSystem;

namespace Skripts
{
    public class PlayerOneInputSystem : MonoBehaviour
    {
        [SerializeField] private PlayerOne _playerone;

        public void OnHorizontalMovement(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<Vector2>();
            _playerone.SetDirection(direction);
        }

    }
}
