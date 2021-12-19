using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabEnemy;

    public float posX;
    public float posY;
    public float posZ;
    public int enemy;

    private GameObject _enemy;

    void Start()
    {

    }

    void Update()
    {
        WanderingAI _enemy1 = GetComponent<WanderingAI>();
        if (_enemy == null)
        {
            int id = Random.Range(0, prefabEnemy.Length);
            Debug.Log(id);
            if (enemy != 0)
            {
                enemy--;
                _enemy = Instantiate(prefabEnemy[id]) as GameObject;
                _enemy.transform.position = new Vector3(posX, posY, posZ);
                float angle = Random.Range(0, 360);
                _enemy.transform.Rotate(0, angle, 0);
            }
        }
    }
}
