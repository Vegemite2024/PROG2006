using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;

    RectTransform obstacle;
    Vector2 startPosition;

    void Start()
    {
        obstacle = GetComponent<RectTransform>();
        startPosition = obstacle.anchoredPosition;
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (Vector2.Distance(
            obstacle.anchoredPosition,
            player.anchoredPosition
        ) < 80f)
        {
            Debug.Log("uh-oh!");

            player.GetComponent<MiniGamePlayer>().ResetPlayer();

            obstacle.anchoredPosition = startPosition;
        }
    }
}