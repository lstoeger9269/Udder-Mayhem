using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emote : MonoBehaviour
{

    public GameObject Camera;
    public GameObject EmoteCam;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            Emoting();
        else if (Input.GetKeyUp(KeyCode.X))
            Stop();        
    }

    void Emoting(){
        Camera.SetActive(false);
        EmoteCam.SetActive(true);
        anim.SetBool("isEmoting", true);
    }

    void Stop(){
        Camera.SetActive(true);
        EmoteCam.SetActive(false);
        anim.SetBool("isEmoting", false);
    }
}
