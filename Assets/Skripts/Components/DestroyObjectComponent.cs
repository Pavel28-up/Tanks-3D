using UnityEngine;

namespace Skripts.Components
{
    public class DestroyObjectComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _objectToDestroy;

        public void DestroyObject()
        {
            _objectToDestroy.SetActive(false);
        }
    }
}
