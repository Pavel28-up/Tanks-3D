using UnityEngine;

namespace Skripts.Components
{
    public class PlayerArmorComponent : MonoBehaviour
    {
        [SerializeField] private int _armor;

        public void ApplyPlayerArmor(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthArmorComponent>();
            if (healthComponent != null)
            {
                healthComponent.ApplyPlayerArmor(_armor);
            }
        }
    }
}
