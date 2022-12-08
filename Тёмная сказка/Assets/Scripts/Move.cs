using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0.5f;
    public float sprint;
    private Vector3 moveVector;
    [SerializeField] KeyCode keyShift;
    [SerializeField] KeyCode keySpace;
    public float jumpForce = 1f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        if (Input.GetKey(keyShift))
        {
            rb.MovePosition(rb.position + moveVector * (speed + sprint) * Time.deltaTime);
        }
        else 
        {
            rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((this.CompareTag("Player") && other.CompareTag("Ground")) && Input.GetKey(keySpace))
        {
            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }
    }
}