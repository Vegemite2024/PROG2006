using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;
    public GameObject speechBubble;
    public ObstacleScript obstacle;
    public CollectibleScript collectible;

    bool talked;
    Vector2 startPosition;

    void Start()
    {
        speechBubble.SetActive(false);
        startPosition = GetComponent<RectTransform>().anchoredPosition;
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (!talked &&
            Vector2.Distance(
                GetComponent<RectTransform>().anchoredPosition,
                player.anchoredPosition
            ) < 100f)
        {
            talked = true;
            moveSpeed = 0f;
            obstacle.moveSpeed = 0f;
            collectible.paused = true;
            speechBubble.SetActive(true);
        }
    }

    public void Resume()
    {
        speechBubble.SetActive(false);
        moveSpeed = 40f;
        collectible.paused = false;
        obstacle.moveSpeed = 40f;
    }

    public void ResetNPC()
    {
        talked = false;
        moveSpeed = 40f;
        speechBubble.SetActive(false);
        GetComponent<RectTransform>().anchoredPosition = startPosition;
    }
}