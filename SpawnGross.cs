using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGross : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Spawn1;
    public float Left = -1f;
    public float Right = 1f;
    public float TimeFirst = 1f;
    public float TimeSecond = 2f;
    public float TimeLive = 10f;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            float randSec = Random.Range(TimeFirst, TimeSecond);
            yield return new WaitForSeconds(randSec);

            float randY = Random.Range(Left, Right);
            if (GameObject.Find("Player") != null)
            {
                //var rotation = Quaternion.Euler(0, 0, -90);
                GameObject newEnemy = Instantiate(Enemy, new Vector3(Spawn1.transform.position.x, randY, 0), Quaternion.identity);
                //newLaser.GetComponent<AsteroidMove>().Rocket = Rocket;
                Destroy(newEnemy, TimeLive);
            }


        }
    }
}
