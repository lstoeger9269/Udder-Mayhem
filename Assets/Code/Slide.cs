using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public float slideSpeed = 10f;

    public GameObject Camera;
    public GameObject Camera2;
    public float walkSpeed = 6f;

    Vector3 moveDirection = Vector3.zero;
    bool isSliding;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && Input.GetKey(KeyCode.W))
            Sliding();
        else if (Input.GetKeyUp(KeyCode.C))
            GoUp();
    }

    private void Sliding()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isSliding = true;
        bool canMove = true;
        float curSpeedX = canMove ? (isSliding ? slideSpeed : walkSpeed)
* Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isSliding ? slideSpeed : walkSpeed)
* Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);
        CameraTwo();
    }

    private void GoUp()
    {
        CameraOne();
    }

    void CameraOne()
    {
        Camera.SetActive(true);
        Camera2.SetActive(false);
    }

    void CameraTwo()
    {
        Camera.SetActive(false);
        Camera2.SetActive(true);
    }
}
