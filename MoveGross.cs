using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGross : MonoBehaviour
{
    public float moveSpeed = 3;
    public Vector2 direction;

    void Update()
    {
        transform.Translate(direction.normalized * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Zone")
        {
            Destroy(this.gameObject);
        }
    }
}
