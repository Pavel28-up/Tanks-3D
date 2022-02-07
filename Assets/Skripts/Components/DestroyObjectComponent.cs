using UnityEngine;

namespace Skripts.Components
{
    public class DestroyObjectComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _objectToDestroy;
        [SerializeField] private GameObject _objectToActive;

        public void DestroyObject()
        {
            Destroy(_objectToDestroy);
        }

        public void SetActiveObject()
        {
            _objectToActive.SetActive(false);
        }
    }
}
