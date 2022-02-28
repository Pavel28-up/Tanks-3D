using UnityEngine;
using UnityEngine.Events;
using System;

namespace Skripts.Components
{
    public class EnterTriggerComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent<GameObject> _action;

        public void OnTriggerEnter(Collider other)
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