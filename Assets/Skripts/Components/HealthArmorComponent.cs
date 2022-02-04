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
        [SerializeField] private float _armorTimer;

        private bool _checkArmorTimer = false;

        public void Update()
        {
            if (_checkArmorTimer)
            {
                _armorTimer -= Time.deltaTime;
            }

            if (_armorTimer <= 0)
            {
                _health = 1;
                _checkArmorTimer = false;
            }
        }

        public void ApplyDamage(int damageValue)
        {
            if (_armor > 0)
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

        public void ApplyTimedArmor(int armorValue)
        {
            _checkArmorTimer = true;
            _health += armorValue;
        }

        public void ApplyPlayerArmor(int armorValue)
        {
            _armor += armorValue;
        }
    }
}