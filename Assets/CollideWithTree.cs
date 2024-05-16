using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithTree : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject textBackground;
    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        textBackground.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            Debug.Log("Collided with tree");
            text1.SetActive(true);
            textBackground.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)){
                Debug.Log("e");
                text1.SetActive(false);
                text2.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E)){
                    text2.SetActive(false);
                    text3.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E)){
                        text3.SetActive(false);
                        text4.SetActive(true);
                        if (Input.GetKeyDown(KeyCode.E))
                            text4.SetActive(false);
                            textBackground.SetActive(false);

                    }
                }
            }

        }
    }
}
