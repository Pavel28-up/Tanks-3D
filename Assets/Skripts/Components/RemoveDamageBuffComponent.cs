using UnityEngine;

namespace Skripts.Components
{
    public class RemoveDamageBuffComponent : MonoBehaviour
    {
        [SerializeField] private int _usualDamage;

        public void DisabbleDamageBuff(GameObject target)
        {
            var healthComponent = target.GetComponent<DamageComponent>();
            healthComponent.DisabbleDamageBuff(_usualDamage);
        }
    }
}