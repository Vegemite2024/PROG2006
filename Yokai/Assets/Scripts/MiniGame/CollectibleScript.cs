using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;
    public bool paused;

    RectTransform item;
    Vector2 startPosition;

    void Start()
    {
        item = GetComponent<RectTransform>();
        startPosition = item.anchoredPosition;
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
            player.localScale *= 1.1f;
            gameObject.SetActive(false);
        }
    }

    public void ResetCollectible()
    {
        item.anchoredPosition = startPosition;
        player.localScale = Vector3.one;
        paused = false;
        gameObject.SetActive(true);
    }
}