using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimGirl : MonoBehaviour
{
    public Animation anim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim = GetComponent<Animation>();
            anim.Play("Scene");
        }
    }
}
