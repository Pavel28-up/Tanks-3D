using UnityEngine;

namespace Skripts.Components
{
    public class RemoveDamageBuffComponent : MonoBehaviour
    {
        public void RemoveDamageBuff(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthArmorComponent>();
            if (healthComponent != null)
            {
                healthComponent.RemoveDamageBuff();
            }
        }
    }
}