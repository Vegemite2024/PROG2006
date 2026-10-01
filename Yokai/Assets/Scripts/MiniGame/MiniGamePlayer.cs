using UnityEngine;

public class MiniGamePlayer : MonoBehaviour
{
    public float moveSpeed = 300f;
    public float jumpSpeed = 500f;

    RectTransform player;
    bool jumping;

    float groundY;

    void Start()
    {
        player = GetComponent<RectTransform>();
        groundY = player.anchoredPosition.y;
    }

    void Update()
    {
 

        if (jumping)
        {
            player.anchoredPosition += Vector2.up * jumpSpeed * Time.deltaTime;

            if (player.anchoredPosition.y > groundY + 150f)
                jumping = false;
        }
        else if (player.anchoredPosition.y > groundY)
        {
            player.anchoredPosition += Vector2.down * jumpSpeed * Time.deltaTime;
        }

        player.anchoredPosition = new Vector2(
            Mathf.Clamp(player.anchoredPosition.x, -405f, 405f),
            player.anchoredPosition.y
        );
    }


    public void Jump()
    {
        if (player.anchoredPosition.y <= groundY)
            jumping = true;
    }
}