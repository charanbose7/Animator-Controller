using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaton : MonoBehaviour
{   
    Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            ani.SetBool("isRunning", true);
        }
        if(Input.GetKey(KeyCode.S))
        {
            ani.SetBool("isRunning", false);
        }
    }
}
