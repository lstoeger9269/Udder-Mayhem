using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshoot : MonoBehaviour
{
    [SerializeField] private LayerMask RandomCubesLayer;
    private Camera MainCamera;

    void Start()
    {
        MainCamera = Camera.main;
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(0)){
            Ray gunray = new Ray(MainCamera.transform.position, MainCamera.transform.forward);
            if(Physics.Raycast(gunray, out RaycastHit hitinfo, 100f, RandomCubesLayer));
       }
    }
}
