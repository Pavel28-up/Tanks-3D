using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabEnemy;
    [SerializeField] public WanderingAI quantity1;
    [SerializeField] public WanderingAI quantity2;
    [SerializeField] public WanderingAI quantity3;
    [SerializeField] public WanderingAI quantity4;

    public float posX;
    public float posY;
    public float posZ;
    //public int enemy1;
    private GameObject _enemy;

    void Start()
    {

    }

    void Update()
    {
        GetComponent<WanderingAI>();
        if (_enemy == null)
        {
            int id = Random.Range(0, prefabEnemy.Length);
            if (quantity1.armor != 0)
            {
                quantity1.armor--;
                if (quantity1.life != 0)
                {
                    quantity1.life--;
                    _enemy = Instantiate(prefabEnemy[id]) as GameObject;
                    _enemy.transform.position = new Vector3(posX, posY, posZ);
                    float angle = Random.Range(0, 360);
                    _enemy.transform.Rotate(0, angle, 0);
                }
            }
            else if (quantity2.armor != 0)
            {
                quantity2.armor--;
                if (quantity2.life != 0)
                {
                    quantity2.life--;
                    _enemy = Instantiate(prefabEnemy[id]) as GameObject;
                    _enemy.transform.position = new Vector3(posX, posY, posZ);
                    float angle = Random.Range(0, 360);
                    _enemy.transform.Rotate(0, angle, 0);
                }
            }
            else if (quantity3.armor != 0)
            {
                quantity3.armor--;
                if (quantity3.life != 0)
                {
                    quantity3.life--;
                    _enemy = Instantiate(prefabEnemy[id]) as GameObject;
                    _enemy.transform.position = new Vector3(posX, posY, posZ);
                    float angle = Random.Range(0, 360);
                    _enemy.transform.Rotate(0, angle, 0);
                }
            }
            else if (quantity4.armor != 0)
            {
                quantity4.armor--;
                if (quantity4.life != 0)
                {
                    quantity4.life--;
                    _enemy = Instantiate(prefabEnemy[id]) as GameObject;
                    _enemy.transform.position = new Vector3(posX, posY, posZ);
                    float angle = Random.Range(0, 360);
                    _enemy.transform.Rotate(0, angle, 0);
                }
            }
        }
    }
}
