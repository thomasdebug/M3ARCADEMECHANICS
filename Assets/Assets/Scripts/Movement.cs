using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    private float speed = 5.0f; // Set player's movement speed.
    public Rigidbody rb; // Reference to player's Rigidbody.

    public bool isGrounded;

    void OnCollisionStay()
    {
        isGrounded = true;
    }
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {




        if (Input.GetKey(KeyCode.D))
        {
            rb.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
             rb.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("jump");
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("hit");
        if (collision.gameObject.tag == "floor") {

            Debug.Log("hit floor");
            isGrounded |= true;
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("!!");
    }



}
