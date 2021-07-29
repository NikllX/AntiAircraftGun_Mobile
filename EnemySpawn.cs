using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPlane;
    public GameObject Spawn;
    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        while (true)
        {
            float randSec = Random.Range(1.5f, 4f);

            yield return new WaitForSeconds(randSec);
            if (GameObject.Find("Player") != null)
            {
                GameObject newEnemyPlane = Instantiate(EnemyPlane, new Vector3(Spawn.transform.position.x, Spawn.transform.position.y, 0), Quaternion.identity);
                Destroy(newEnemyPlane, 10);
            }
        }
    }
}
