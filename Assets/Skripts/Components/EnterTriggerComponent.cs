using UnityEngine;
using UnityEngine.Events;
using System;

namespace Skripts.Components
{
    public class EnterTriggerComponent : MonoBehaviour
    {
        [SerializeField] private TriggerStages[] _stages;

        public void OnTriggerEnter(Collider other)
        {
            foreach (var stage in _stages)
            {
                if (other.gameObject.CompareTag(stage.Tag))
                {
                    stage.Action?.Invoke(other.gameObject);
                    return;
                }
            }
        }

        [Serializable]
        public class EnterEvent : UnityEvent<GameObject>
        {
        }

        [Serializable]
        public class TriggerStages
        {
            [SerializeField] private string _tag;
            [SerializeField] private EnterEvent _action;

            public string Tag => _tag;
            public EnterEvent Action => _action;
        }
    }
}