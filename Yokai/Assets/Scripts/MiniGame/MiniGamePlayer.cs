using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{
    public float jumpSpeed = 400f;
    public float fallSpeed = 100f;

    RectTransform player;
    bool jumping;

    float groundY;
    Vector2 startPosition;

    void Start()
    {
        player = GetComponent<RectTransform>();
        groundY = player.anchoredPosition.y;
        startPosition = player.anchoredPosition;
    }

    void Update()
    {
        if (jumping)
        {
            player.anchoredPosition += Vector2.up * jumpSpeed * Time.deltaTime;

            if (player.anchoredPosition.y > groundY + 200f)
                jumping = false;
        }
        else if (player.anchoredPosition.y > groundY)
        {
            player.anchoredPosition += Vector2.down * fallSpeed * Time.deltaTime;

            if (player.anchoredPosition.y < groundY)
                player.anchoredPosition = new Vector2(
                    player.anchoredPosition.x,
                    groundY
                );
        }
    }

    public void Jump()
    {
        if (player.anchoredPosition.y <= groundY)
            jumping = true;
    }

    //Player dead
    public void ResetPlayer()
    {
        player.anchoredPosition = startPosition;
        jumping = false;
    }
}