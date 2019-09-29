using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed;

    private Collider playerCollider;
    private Rigidbody2D rb2d;
    public GameObject Lazor;
    public int healthpoints;

    
    void Start()
    {
        playerCollider = GetComponent<Collider>();
        rb2d = GetComponent<Rigidbody2D> ();
    }

    private bool IsCharacterOffScreen()
    {
        return true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal * speed, moveVertical * speed);

        bool isOnScreen = IsCharacterOffScreen();

        if(isOnScreen)
        {
            rb2d.position += movement;
        }
        else
        {
            //put back on screen
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = (GameObject)(Instantiate(Lazor, 
            transform.position + transform.right, Quaternion.identity));

            b.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);
        }

        if(healthpoints < 0)
        {
            Destroy(gameObject);
        }
    }

    void ApplyDamage(int n)
    {
        healthpoints -= n;
    }




}
