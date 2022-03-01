using UnityEngine;
using UnityEngine.Events;

namespace Skripts.Components
{
    public class FlagTimerComponent : MonoBehaviour
    {
        [SerializeField] private float _damageBuffTimer;
        [SerializeField] private UnityEvent _onTimerStart;
        [SerializeField] private UnityEvent _onTimerEnd;

        private bool _startFirstEvent = false;
        private bool _startSecondEvent = false;


        public void Update()
        {
            if (_startFirstEvent)
            {
                _onTimerStart?.Invoke();
                _startFirstEvent = false;
            }

            if (_startSecondEvent)
            {
                _damageBuffTimer -= Time.deltaTime;
            }

            if (_damageBuffTimer <= 0)
            {
                _onTimerEnd?.Invoke();
                _damageBuffTimer = 5f;
                _startSecondEvent = false;
            }

        }

        public void StartTimer()
        {
            _startFirstEvent = true;
            _startSecondEvent = true;
        }
    }
}
