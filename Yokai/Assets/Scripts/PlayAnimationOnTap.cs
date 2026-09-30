
using UnityEngine;

public class PlayAnimationOnTap : MonoBehaviour
{
    public Animator animator;
    public string triggerName = "PlayNeko";





    public void PlayAnimation()
    {
        animator.SetTrigger(triggerName);
        gameObject.SetActive(false);
    }
}
