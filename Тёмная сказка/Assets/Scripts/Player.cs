using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyUp;
    [SerializeField] KeyCode keyDown;
    [SerializeField] KeyCode keyRight;
    [SerializeField] KeyCode keyLeft;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] Vector3 moveDirection1;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyUp))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyDown))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(keyRight))
        {
            GetComponent<Rigidbody>().velocity += moveDirection1;
        }
        if (Input.GetKey(keyLeft))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection1;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
