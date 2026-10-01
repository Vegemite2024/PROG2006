using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;

    RectTransform item;
    Vector2 startPosition;

    void Start()
    {
        item = GetComponent<RectTransform>();
        startPosition = item.anchoredPosition;
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (Vector2.Distance(
            item.anchoredPosition,
            player.anchoredPosition
        ) < 70f)
        {
            gameObject.SetActive(false);
        }
    }
}