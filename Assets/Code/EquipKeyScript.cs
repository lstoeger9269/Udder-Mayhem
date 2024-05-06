using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipKeyScript : MonoBehaviour
{
    public Transform KeyTransform;
    public GameObject Key;
    public GameObject Key2;
    public GameObject Key3;
    public Camera Camera;
    public float pickUpRangeKey;
    public GameObject open;
    public GameObject open2;
    public GameObject open3;
    public bool fun;
    public bool fun2;
    public bool fun3;
    public static bool move;
    public Transform cageTransform;
    public Transform cageTransform2;
    public Transform cageTransform3;
    public float useKeyRange;
    public int var;
    public GameObject cowtext;

    //[SerializeField]
    public GameObject enemy;
    public float enemyInterval = 1;
    public int times;
    public int timesLimit = 5;


    


    void Start()
    {
        Key.GetComponent<Rigidbody>().isKinematic = true;
        fun = false;
        fun2 = false;
        fun3 = false;
        move = false;
        cowtext.active = false;
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
        enemy.active = false;
        times = 1;


    }

    void Update()
    {
        Vector3 distanceToPlayer = KeyTransform.position - transform.position;
        
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey && var > 4 && var <= 5){
        
        EquipKey();
        fun = true;

        }
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey && var > 9 && var <= 10){
        
        EquipKey2();
        fun2 = true;
        

        }
        
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey && var > 14){
        
        EquipKey3();
        fun3 = true;
     

        }

        if (Input.GetKeyDown("m")){

            var += 1;
        }

        Vector3 keyRange = KeyTransform.position - cageTransform.position;
        Vector3 keyRange2 = KeyTransform.position - cageTransform2.position;
        Vector3 keyRange3 = KeyTransform.position - cageTransform3.position;

        if(Input.GetKeyDown("o") && fun == true && keyRange.magnitude <= useKeyRange){
                open.GetComponent<Animator>().Play("cageanimation");
                move = true;
                Destroy(Key);

        }
        
        if(Input.GetKeyDown("o") && fun2 == true && keyRange2.magnitude <= useKeyRange){
                open2.GetComponent<Animator>().Play("cageanimation");
                move = true;
                Destroy(Key2);
        }
        if(Input.GetKeyDown("o") && fun3 == true && keyRange3.magnitude <= useKeyRange){
                open3.GetComponent<Animator>().Play("cageanimation");
                move = true;
                Destroy(Key3);
        }
        if(Input.GetKeyDown(KeyCode.O)){
            EquipKey();
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Key"){
            EquipKey();
            Debug.Log("key equiped");
        }
    }

    void EquipKey()
    {
        Key.GetComponent<Rigidbody>().isKinematic = true;
        Key.transform.position = KeyTransform.transform.position;
        Key.transform.rotation = KeyTransform.transform.rotation;
        Key.transform.SetParent(KeyTransform);
        
    }

    void EquipKey2()
    {
        Key2.GetComponent<Rigidbody>().isKinematic = true;
        Key2.transform.position = KeyTransform.transform.position;
        Key2.transform.rotation = KeyTransform.transform.rotation;
        Key2.transform.SetParent(KeyTransform);
        
    }

    void EquipKey3()
    {
        Key3.GetComponent<Rigidbody>().isKinematic = true;
        Key3.transform.position = KeyTransform.transform.position;
        Key3.transform.rotation = KeyTransform.transform.rotation;
        Key3.transform.SetParent(KeyTransform);
        
    }

    public IEnumerator spawnEnemy(float enemyInterval, GameObject enemy){

      if (times <= timesLimit){

        yield return new WaitForSeconds(enemyInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        times++;
        print(times);
        newEnemy.active = true;
      }
    } 
}