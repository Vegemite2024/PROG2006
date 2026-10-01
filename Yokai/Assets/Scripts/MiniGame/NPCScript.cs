using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;
    public GameObject speechBubble;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (Vector2.Distance(
            GetComponent<RectTransform>().anchoredPosition,
            player.anchoredPosition
        ) < 150f)
        {
            moveSpeed = 0f;
            speechBubble.SetActive(true);
        }
    }
}