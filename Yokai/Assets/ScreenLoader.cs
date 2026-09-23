using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadChapter1()
    {
        SceneManager.LoadScene("Chapter1");
    }

    public void LoadChapter2()
    {
        SceneManager.LoadScene("Chapter2");
    }

    public void LoadChapter3()
    {
        SceneManager.LoadScene("Chapter3");
    }

    public void LoadChapter4()
    {
        SceneManager.LoadScene("Chapter4");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}