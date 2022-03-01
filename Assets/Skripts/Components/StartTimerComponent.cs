using UnityEngine;

namespace Skripts.Components
{
    public class StartTimerComponent : MonoBehaviour
    {
        public void StartTimer(GameObject target)
        {
            var healthComponent = target.GetComponent<TimerComponent>();
            if (healthComponent != null)
            {
                healthComponent.StartTimer();
            }
        }
    }
}
