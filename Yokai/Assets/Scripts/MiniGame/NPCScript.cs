using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;
    public GameObject speechBubble;

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
            speechBubble.SetActive(true);

            FindObjectOfType<MiniGameController>().PauseMiniGame();
        }
    }

    public void Resume()
    {
        speechBubble.SetActive(false);
        moveSpeed = 40f;

        FindObjectOfType<MiniGameController>().ResumeMiniGame();
    }

    public void ResetNPC()
    {
        GetComponent<RectTransform>().anchoredPosition = startPosition;
        talked = false;
        moveSpeed = 40f;
        speechBubble.SetActive(false);
    }
}