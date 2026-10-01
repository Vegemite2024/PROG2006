using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float moveSpeed = 300f;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}