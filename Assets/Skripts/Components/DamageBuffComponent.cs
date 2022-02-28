using UnityEngine;

namespace Skripts.Components
{
    public class DamageBuffComponent : MonoBehaviour
    {
        [SerializeField] private int _damageBuff;

        public void ApplyDamageBuff(GameObject target)
        {
            var healthComponent = target.GetComponent<DamageComponent>();
            healthComponent.ApplyDamageBuff(_damageBuff);
        }
    }
}