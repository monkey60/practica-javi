using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneco : MonoBehaviour
{

    public float mover;

    // Use this for initialization
    void Start()
    {


    }

    void Update()
    {
        //  Movement1();
        MouseMovement1();
    }

    private void Movement1()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = 10 * new Vector2(horizontal, vertical);
    }

    private void MouseMovement1()
    {

        transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 10 * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Magnético")) {
            collision.transform.parent = transform;
        } 
    }

}


