using UnityEngine;

namespace Skripts.Components
{
    public class TimedArmorFlagComponent : MonoBehaviour
    {
        [SerializeField] private int _armor;

        public void ApplyTimedArmor(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthArmorComponent>();
            if (healthComponent != null)
            {
                healthComponent.ApplyTimedArmor(_armor);
            }
        }
    }
}
