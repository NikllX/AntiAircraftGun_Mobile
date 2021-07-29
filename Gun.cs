using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotPoint;
    public Joystick joystick;

    private float timeBtwShots;
    public float startTimeBtwShots;
    private float rotationZ;
    private Vector3 difference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationZ = Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * Mathf.Rad2Deg;

        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + offset);
        }
        

        if (timeBtwShots <= 0)
        {
            if (joystick.Horizontal != 0 || joystick.Vertical != 0)
            {
                Shoot();
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    public void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, shotPoint.position, Quaternion.Euler(0.0f, 0.0f, rotationZ -90 ));
        timeBtwShots = startTimeBtwShots;
        Destroy(newBullet, 5);
    }
}
