using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class LetterColorChange : MonoBehaviour, IPointerClickHandler
{
    private TMP_Text letterText;

    private void Awake()
    {
        letterText = GetComponent<TMP_Text>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        letterText.color = new Color32(173, 45, 45, 255);
    }
}