using UnityEngine;

public class MiniGameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject endingPanel;
    public GameObject playButton;

    public MiniGamePlayer player;
    public NPCScript npc;
    public CollectibleScript collectible;

    ObstacleScript[] obstacles;
    PeopleEndScript people;

    bool gameStarted;

    void Start()
    {
        gameOverPanel.SetActive(false);
        endingPanel.SetActive(false);

        obstacles = FindObjectsOfType<ObstacleScript>();
        people = FindObjectOfType<PeopleEndScript>();

        PauseMiniGame();
    }

    public void StartMiniGame()
    {
        gameStarted = true;

        playButton.SetActive(false);

        ResumeMiniGame();
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);

        PauseMiniGame();
        npc.moveSpeed = 0f;
        people.moveSpeed = 0f;
    }

    public void GameWon()
    {
        endingPanel.SetActive(true);

        PauseMiniGame();
        npc.moveSpeed = 0f;
        people.moveSpeed = 0f;
    }

    public void PlayAgain()
    {
        gameOverPanel.SetActive(false);
        endingPanel.SetActive(false);

        player.ResetPlayer();

        foreach (ObstacleScript obstacle in obstacles)
        {
            obstacle.ResetObstacle();
        }

        collectible.ResetCollectible();
        npc.ResetNPC();
        people.ResetPeople();

        playButton.SetActive(true);
        gameStarted = false;

        PauseMiniGame();
    }

    public void PauseMiniGame()
    {
        foreach (ObstacleScript obstacle in obstacles)
        {
            obstacle.moveSpeed = 0f;
        }

        collectible.paused = true;
        npc.moveSpeed = 0f;
        people.moveSpeed = 0f;
    }

    public void ResumeMiniGame()
    {
        foreach (ObstacleScript obstacle in obstacles)
        {
            obstacle.moveSpeed = 40f;
        }

        collectible.paused = false;
        npc.moveSpeed = 40f;
        people.moveSpeed = 40f;
    }
}