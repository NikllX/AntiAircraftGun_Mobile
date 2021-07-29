using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Enemy")
        {
            Destroy(ColAsteroid.gameObject);
            Destroy(this.gameObject);
        }
        if (ColAsteroid.gameObject.tag == "Zone")
        {
            Destroy(this.gameObject);
        }
    }
}
