using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
    public class stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }

    public stuff myStuff = new stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;


    // Update is called once per frame
    void Update()
    {
        Movement();
       
    }


    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}