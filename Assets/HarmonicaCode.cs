using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmonicaCode : MonoBehaviour
{
    GameObject harmonica;
    // Start is called before the first frame update
    void Start()
    {
        harmonica = GameObject.Find("harmonica");
        harmonica.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X) && harmonica == true)
        {
            harmonica.SetActive(false);
        }
        if(Input.GetKey(KeyCode.X) && harmonica == false)
        {
            harmonica.SetActive(true);
        }
    }
}
