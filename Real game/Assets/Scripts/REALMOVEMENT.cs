using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REALMOVEMENT : MonoBehaviour
{
    public float speed;

    public float MaxSpeed;

    Rigidbody2D rb;

    public Transform cam;

    public Vector3 Offset;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.magnitude < MaxSpeed)
        {
            rb.AddForce(transform.right * speed * Input.GetAxis("Horizontal"));
        }

        //cam.transform.position = Vector3.Lerp(cam.position, transform.position + Offset, 0.2f);
    }
}
