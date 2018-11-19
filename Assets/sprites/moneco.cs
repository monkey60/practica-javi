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

        gameObject.transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.5f);
    }
}


