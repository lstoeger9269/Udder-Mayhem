using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimation : MonoBehaviour
{
    bool Running;
    Animator anim;

    void Start()
    {
        Running = true;
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Running=true)
        {
            anim.SetBool("isRunning", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("attack");
        }
    }
}
