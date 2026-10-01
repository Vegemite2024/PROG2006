using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;
    public bool paused;

    RectTransform item;
    Vector2 startPosition;
    Vector3 playerStartScale;

    void Start()
    {
        item = GetComponent<RectTransform>();
        startPosition = item.anchoredPosition;
        playerStartScale = player.localScale;
    }

    void Update()
    {
        if (paused)
            return;

        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (Vector2.Distance(
            item.anchoredPosition,
            player.anchoredPosition
        ) < 70f)
        {
            player.localScale *= 2.2f;
            gameObject.SetActive(false);
        }
    }

    public void ResetCollectible()
    {
        item.anchoredPosition = startPosition;
        player.localScale = playerStartScale;
        paused = false;
        gameObject.SetActive(true);
    }
}