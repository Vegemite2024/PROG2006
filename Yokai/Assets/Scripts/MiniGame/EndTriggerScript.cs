using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    public RectTransform player;

    RectTransform trigger;

    void Start()
    {
        trigger = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (Vector2.Distance(
            trigger.anchoredPosition,
            player.anchoredPosition
        ) < 80f)
        {
            MiniGameController controller =
                FindObjectOfType<MiniGameController>();

            controller.GameWon();
        }
    }
}