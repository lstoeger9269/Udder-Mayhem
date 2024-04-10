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
        anim = GetComponent<Animator>();
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
            anim.SetBool("isAttacking", true);
            System.Threading.Thread.Sleep(1000);
            anim.SetBool("isAttacking",false);
        }
    }
}
