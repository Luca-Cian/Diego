
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public Vector3 offset;


    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.position+offset;

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(new Vector3(transform.position.x,0,transform.position.z), new Vector3(targetPosition.x,0,targetPosition.z) , ref velocity, smoothTime);
    }
}
