using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            target.Rotate(0, -Input.GetAxis("Mouse X") * 2, 0);
     
        }
    }
}