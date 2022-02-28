using UnityEngine.Events;
using UnityEngine;

namespace Skripts.Components
{
    public class HealthArmorComponent : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private int _armor;
        [SerializeField] private UnityEvent _onHPDamage;
        [SerializeField] private UnityEvent _onArmorDamage;
        [SerializeField] private UnityEvent _onDie;

        private bool _checkArmor;

        private void Update()
        {
            if (_armor > 0)
            {
                _checkArmor = true;
            }
            else if (_armor == 0)
            {
                _checkArmor = false;
            }
        }

        public void ApplyDamage(int damageValue)
        {
            if (_checkArmor)
            {
                _armor -= damageValue;
                _onArmorDamage?.Invoke();
            }
            else
            {
                _health -= damageValue;
                _onHPDamage?.Invoke();

                if (_health <= 0)
                {
                    _onDie?.Invoke();
                }
            }
        }

        public void ApplyHeal(int healValue)
        {
            _health += healValue;
        }

        public void ApplyPlayerArmor(int armorValue)
        {
            _armor += armorValue;
        }

        public void DisabbleArmorBuff(int _usualArmor)
        {
            _armor = _usualArmor;
        }
    }
}