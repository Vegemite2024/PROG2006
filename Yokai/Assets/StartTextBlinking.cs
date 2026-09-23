using UnityEngine;
using TMPro;

public class StartTextBlink : MonoBehaviour
{
    public float blinkSpeed = 1f;

    private TMP_Text startText;

    void Start()
    {
        startText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        float alpha = Mathf.Abs(Mathf.Sin(Time.time * blinkSpeed));

        Color colour = startText.color;
        colour.a = alpha;
        startText.color = colour;
    }
}