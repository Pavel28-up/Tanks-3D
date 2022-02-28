using UnityEngine;

namespace Skripts.Components
{
    public class DamageComponent : MonoBehaviour
    {
        [SerializeField] private int _damage;

        public void ApplyDamage(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthArmorComponent>();
            if (healthComponent != null)
            {
                healthComponent.ApplyDamage(_damage);
            }
        }

        public void ApplyDamageBuff(int _damageBuffValue)
        {
            _damage += _damageBuffValue;
        }

        public void DisabbleDamageBuff(int _usualDamage)
        {
            _damage = _usualDamage;
        }
    }
}