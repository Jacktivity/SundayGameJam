using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSquare : MonoBehaviour
{
    public float speed;
    public int health;
    private Rigidbody2D rb2d;
    private float shootTime;
    public GameObject bullet;
    public float bulletSpawn;
    public float maxSpeed = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(transform.up * speed, ForceMode2D.Impulse);

        shootTime += Time.deltaTime;
        if (shootTime >= bulletSpawn)
        {
            shootTime = 0;
            var spawn = transform.position - (transform.up * 1.5f);
           //var go = Instantiate(bullet, spawn, new Quaternion());
        }


        rb2d.velocity = Vector3.ClampMagnitude(rb2d.velocity, maxSpeed);

        if (health < 0)
        {
            Destroy(gameObject);
        }
    }

    void ApplyDamage(int n)
    {
        health =- n;
    }
}
