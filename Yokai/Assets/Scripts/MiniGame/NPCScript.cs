using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;
    public GameObject speechBubble;
    public ObstacleScript obstacle;
  



    void Start()
    {
        speechBubble.SetActive(false);
    }
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (Vector2.Distance(
            GetComponent<RectTransform>().anchoredPosition,
            player.anchoredPosition
        ) < 100f)
        {
            moveSpeed = 0f;
            obstacle.moveSpeed = 0f;
            speechBubble.SetActive(true);
        }
    }

    public void Resume()
    {
        speechBubble.SetActive(false);
        moveSpeed = 40f;
        obstacle.moveSpeed = 40f;
    }
}