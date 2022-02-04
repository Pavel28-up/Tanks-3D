using UnityEngine.Events;
using UnityEngine;
using System;

namespace Skripts.Components
{
    public class EnterCollisionComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent<GameObject> _action;

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag(_tag))
            {
                _action?.Invoke(other.gameObject);
            }
        }

        [Serializable]
        public class EnterEvent : UnityEvent<GameObject>
        {

        }
    }
}