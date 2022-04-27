using UnityEngine;

namespace Skripts.Components
{
    public class DamageComponent : MonoBehaviour
    {
        public void ApplyDamage(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthArmorComponent>();
            if (healthComponent != null)
            {
                healthComponent.ApplyDamage();
            }
        }
    }
}