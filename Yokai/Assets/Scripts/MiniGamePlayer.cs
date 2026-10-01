using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{
    public float moveSpeed = 300f;

    RectTransform player;

    void Start()
    {
        player = GetComponent<RectTransform>();
    }

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        player.anchoredPosition += new Vector2(
            move * moveSpeed * Time.deltaTime,
            0
        );
    }
}