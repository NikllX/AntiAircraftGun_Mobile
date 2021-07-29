using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    public Rigidbody2D rb;
    Vector2 move;
    public Button RestartLevel;
    public int Live = 3;
    private float MoveInput;

    void Update()
    {
        MoveInput = joystick.Horizontal;
        rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);

        if (Live == 0)
        {
            RestartLevel.gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Enemy")
        {
            Destroy(ColAsteroid.gameObject);
            Live -= 1;

        }
    }
}
