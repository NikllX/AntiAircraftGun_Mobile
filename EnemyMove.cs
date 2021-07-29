using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction.normalized * Time.deltaTime * moveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        if (ColAsteroid.gameObject.tag == "PlayerBullet")
        {
            Destroy(this.gameObject);
        }
    }
}
