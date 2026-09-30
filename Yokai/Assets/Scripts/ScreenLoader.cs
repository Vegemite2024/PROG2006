using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScreenLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        StartCoroutine(LoadSceneWithSound("Main"));
    }

    public void LoadChapter1()
    {
        StartCoroutine(LoadSceneWithSound("Chapter1"));
    }

    public void LoadChapter2()
    {
        StartCoroutine(LoadSceneWithSound("Chapter2"));
    }

    public void LoadChapter3P1()
    {
        StartCoroutine(LoadSceneWithSound("Chapter3P1"));
    }
    public void LoadChapter3P2()
    {
        StartCoroutine(LoadSceneWithSound("Chapter3P2"));
    }

    public void LoadChapter4()
    {
        StartCoroutine(LoadSceneWithSound("Chapter4"));
    }

    public void LoadCredits()
    {
        StartCoroutine(LoadSceneWithSound("Credits"));
    }

    //click sound

    [SerializeField] private AudioSource clicksound;

    IEnumerator LoadSceneWithSound(string sceneName)
    {
        clicksound.Play();
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(sceneName);
    }
}