using UnityEngine;

namespace Skripts.Components
{
    public class DamageBuffComponent : MonoBehaviour
    {
        [SerializeField] private int _damageBuff;
        public void DamageBuff(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthArmorComponent>();
            Debug.Log(healthComponent);
            if (healthComponent != null)
            {
                healthComponent._checkDamageBuff = true;
                healthComponent._damageValue += _damageBuff;
            }
        }
    }
}