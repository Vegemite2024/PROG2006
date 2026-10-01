using UnityEngine;

public class MiniGameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject endingPanel;

    public MiniGamePlayer player;
    public NPCScript npc;
    public CollectibleScript collectible;

    ObstacleScript[] obstacles;

    void Start()
    {
        gameOverPanel.SetActive(false);
        endingPanel.SetActive(false);

        obstacles = FindObjectsOfType<ObstacleScript>();
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);

        PauseMiniGame();
        npc.moveSpeed = 0f;
    }

    public void GameWon()
    {
        endingPanel.SetActive(true);

        PauseMiniGame();
        npc.moveSpeed = 0f;
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

        ResumeMiniGame();
    }

    public void PauseMiniGame()
    {
        foreach (ObstacleScript obstacle in obstacles)
        {
            obstacle.moveSpeed = 0f;
        }

        collectible.paused = true;
    }

    public void ResumeMiniGame()
    {
        foreach (ObstacleScript obstacle in obstacles)
        {
            obstacle.moveSpeed = 40f;
        }

        collectible.paused = false;
        npc.moveSpeed = 40f;
    }
}