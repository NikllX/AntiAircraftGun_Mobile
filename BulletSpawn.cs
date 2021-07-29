using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Spaw;
    public int timeStartR = 2;
    public int timeEndR = 5;
    void Start()
    {
        StartCoroutine(Spawner());

    }
    IEnumerator Spawner()
    {
        while (true)
        {
            int randSec = Random.Range(timeStartR, timeEndR);
            yield return new WaitForSeconds(randSec);
            if (GameObject.Find("Player") != null)
            {
                var rotation = Quaternion.Euler(0, 0, 0);
                GameObject newBullet = Instantiate(Bullet, new Vector3(Spaw.transform.position.x , Spaw.transform.position.y, 0), rotation);
                Destroy(newBullet, 5);
            }
        }
    }
}
