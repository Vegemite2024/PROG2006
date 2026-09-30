using UnityEngine;
using TMPro;

public class StartTextBlink : MonoBehaviour
{
    public float timer;
    private TMP_Text startText;

    void Start()
    {
        startText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 0.5f)
        {
            startText.enabled = !startText.enabled;
            timer = 0f;
        }
    }
}