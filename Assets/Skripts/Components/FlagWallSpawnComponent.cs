using UnityEngine;

namespace Skripts.Components
{
    public class FlagWallSpawnComponent : MonoBehaviour
    {
        public void Spawn(GameObject target)
        {
            var spawnComponent = target.GetComponent<SpawnComponent>();
            if (spawnComponent != null)
            {
                spawnComponent.Spawn();
            }
        }
    }
}
