using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    public float offset;
    void Update()
    {
        cam.transform.position = new Vector3(target.position.x - 5, target.position.y + offset, target.position.z);
    }
}
