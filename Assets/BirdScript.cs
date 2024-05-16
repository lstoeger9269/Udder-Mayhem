using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public bool talking = false;
    public bool flying = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!talking && !flying){
            anim.SetBool("birdLeave", true);
            
        }
    }
    private void OnTriggerEnter(Collider collider)
      {
          if (collider.CompareTag("Road"))
          {
            anim.SetBool("birdTalk", true);
            talking = true;
            flying = false;
          }
      }
    
    public void NotTalking()
    {
        talking = false;

    }

}
