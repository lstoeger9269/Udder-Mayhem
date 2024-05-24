using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    Animator anim;
    public bool talking = false;
    public bool flying = true;
    private IEnumerator coroutine;

    public GameObject textbox1;
    public GameObject textbox2;
    public GameObject textbox3;
    public bool text1 = false;
    public bool text2 = false;
    public bool text3 = false;
    public bool bugbool = true;
    public GameObject truckDriver;
    // Start is called before the first frame update
    void Start()
    {
        anim=gameObject.GetComponent<Animator>();

        coroutine = BirdTalk(4.0f);
        StartCoroutine(coroutine);

        textbox1.SetActive(false);
        textbox2.SetActive(false);
        textbox3.SetActive(false);

        truckDriver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!talking && !flying){
            anim.SetBool("birdLeave", true);
            anim.SetBool("birdTalk", false);
            
        }
        if((Input.GetKeyDown(KeyCode.M))){
            if(text1){
                textbox1.SetActive(false);
                text1 = false;
                textbox2.SetActive(true);
                text2 = true;
                Debug.Log("text");
            }
            else if(text2){
                textbox2.SetActive(false);
                text2 = false;
                textbox3.SetActive(true);
                text3 = true;
                Debug.Log("text");
            }
            else if(text3){
                textbox3.SetActive(false);
                text3 = false;
                anim.SetBool("birdLeave", true);
                coroutine = BirdDie(3.0f);
                StartCoroutine(coroutine);
                truckDriver.SetActive(true);
            }
        }
    }
    
    public void Talking(){
        talking = true;
        anim.SetBool("birdTalk", true);
        if(bugbool){
        textbox1.SetActive(true);
        text1 = true;
        bugbool = false;
        Debug.Log("text");
        }
    }
    private IEnumerator BirdTalk(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Talking();
        }
    }
    private IEnumerator BirdDie(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            anim.SetBool("birdTalk", false);
            anim.SetBool("birdLeave", false);
            anim.SetBool("birdDie", true);
        }
    }
}