using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeed = 3;
    public Vector2 direction;
    void Update()
    {
        transform.Translate(direction.normalized * Time.deltaTime * moveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }

        if (ColAsteroid.gameObject.tag == "Zone")
        {
            Destroy(this.gameObject);
        }
    }
}
