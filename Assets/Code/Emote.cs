using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emote : MonoBehaviour
{

    public GameObject Camera;
    public GameObject EmoteCam;

    Animator anim;
    // Start is called before the first frame update
    public void Start()
    {
        anim=gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            Emoting();
        else if (Input.GetKeyUp(KeyCode.X))
            Stop();        
    }

    public void Emoting(){
        Camera.SetActive(false);
        EmoteCam.SetActive(true);
        anim.SetBool("isEmoting", true);
    }

    public void Stop(){
        Camera.SetActive(true);
        EmoteCam.SetActive(false);
        anim.SetBool("isEmoting", false);
    }

    public void Dead()
    {
        anim.SetTrigger("isDead");
    }
}
