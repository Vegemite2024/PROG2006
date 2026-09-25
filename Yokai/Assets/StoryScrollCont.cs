using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryScrollCont : MonoBehaviour
{
    public ScrollRect StoryScroll;

    public bool autoScroll = false;
    public float scrollSpeed = 0.01f;
    public TMP_Text autoScrollText;

    public void JUMPTOP()
    {
        StoryScroll.verticalNormalizedPosition = 1f;
    }

    public void JUMPBOTTOM()
    {
        StoryScroll.verticalNormalizedPosition = 0f;
    }
    
    public void ToggleAutoScroll()
    {
        autoScroll = !autoScroll;
        if (autoScroll)
        {
            autoScrollText.text = "Scroll ON";
        }
        else
        {
            autoScrollText.text = "Scroll OFF";
        }
    }

    void Update()
    {
        if (autoScroll)
        {
            StoryScroll.verticalNormalizedPosition -= scrollSpeed * Time.deltaTime;
        }
    }

  
   
}