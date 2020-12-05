using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitController : MonoBehaviour
{
    public float Speed;
    public Rigidbody rb;
    public bool toucheLeSol = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        RabbitMove();
    }

    void RabbitMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 rabbitMove = new Vector3(horizontal, 0f, vertical) * Speed * Time.deltaTime;
        transform.Translate(rabbitMove, Space.Self);


        if (Input.GetButtonDown("Jump") && toucheLeSol)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            toucheLeSol = false;

        }

    }

    private void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            toucheLeSol = true;
        }
    }
}

   

   

