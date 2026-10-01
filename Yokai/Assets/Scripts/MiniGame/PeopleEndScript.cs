using UnityEngine;

public class PeopleEndScript : MonoBehaviour
{
    public float moveSpeed = 40f;
    public RectTransform player;

    RectTransform people;
    Vector2 startPosition;

    void Start()
    {
        people = GetComponent<RectTransform>();
        startPosition = people.anchoredPosition;
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (Vector2.Distance(
            people.anchoredPosition,
            player.anchoredPosition
        ) < 100f)
        {
            MiniGameController controller =
                FindObjectOfType<MiniGameController>();

            controller.GameWon();
        }
    }

    public void ResetPeople()
    {
        people.anchoredPosition = startPosition;
    }
}