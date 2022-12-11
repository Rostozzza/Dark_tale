using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curse : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 start_pos;
    public float N = 5f;
    public float R = 35f;
    public float M = 50f;
    public float T = 10f;
    public float T_time = 10f;
    public float S = 15f;
    public float Rd = 0f;
    public GameObject Player;
    public float Speed;
    void Start()
    {
        Speed = Player.GetComponent<Move>().speed;
    }

    void Awake()
    {
        start_pos = transform.position;
        T_time = T;
        GetComponent<Collider>().radius = M;
    }

    void Update()
    {
        Vector3 SelfPosition = transform.position;
        Vector3 Dist = GameObject.Find("Player").transform.position;
        if ((T % 1) % N == 0)
        {
            Speed -= 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 pos = new Vector3(Random.Range(-R, R), 0, Random.Range(-R, R));
        transform.position = pos + start_pos;
        start_pos = transform.position;
    }

    void FixedUpdate()
    {
        T += 0.02f;
    }
}
