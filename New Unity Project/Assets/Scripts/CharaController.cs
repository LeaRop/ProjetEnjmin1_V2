using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class CharaController : MonoBehaviour
{

    public float Speed;
    public Rigidbody rb;
    public bool onGround = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMovement();
    }

    void CharacterMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 characterMovement = new Vector3(ver, 0f, hor) * Speed * Time.deltaTime;
        transform.Translate(characterMovement, Space.Self);

        if (Input.GetButtonDown("Jump") && onGround)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            onGround = false;

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onGround = true;
        }
    }
}
