using UnityEngine;
using UnityEngine.UI;

public class AudioToggle : MonoBehaviour
{
    public AudioSource audioSource;
    public Image audioButtonImage;
    public Sprite audioOn;
    public Sprite audioOff;

    private bool isMuted = false;

    public void ToggleAudio()
    {
        isMuted = !isMuted;
        audioSource.mute = isMuted;

        if (isMuted)
        {
            audioButtonImage.sprite = audioOff;
        }
        else
        {
            audioButtonImage.sprite = audioOn;
        }
    }
}