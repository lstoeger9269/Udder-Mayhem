using UnityEngine;

public class FollowWithGravity : MonoBehaviour
{
    public Transform targetObject; // The object to follow
    public float followSpeed = 5f; // The speed at which the object follows
    public float gravityScale = 9.81f; // The scale of gravity

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Calculate the direction and distance to the target object
        Vector3 direction = (targetObject.position - transform.position).normalized;
        float distance = Vector3.Distance(transform.position, targetObject.position);

        // Apply gravity
        rb.AddForce(Vector3.down * gravityScale, ForceMode.Acceleration);

        // Move the object towards the target
        rb.velocity = direction * Mathf.Min(distance, followSpeed);
    }
}