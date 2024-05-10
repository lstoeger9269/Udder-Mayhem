using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f; 
    private bool isLocked = false;
    private Quaternion targetRotation;

    void Update()
    {
        if (isLocked)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            LockOnTarget();
        }
        else
        {
            isLocked = false;
        }
    }

    private void LockOnTarget()
    {
        if (!isLocked)
        {
            isLocked = true;
            Vector3 direction = target.position - transform.position;
            targetRotation = Quaternion.LookRotation(direction);
        }
    }
}
