using UnityEngine;

namespace Skripts.Components
{
    public class StartFlagTimerComponent : MonoBehaviour
    {
        public void StartTimer(GameObject target)
        {
            var healthComponent = target.GetComponent<FlagTimerComponent>();
            if (healthComponent != null)
            {
                healthComponent.StartTimer();
            }
        }
    }
}