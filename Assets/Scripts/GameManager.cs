using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public PlayerController player;
    public EnemyMovement enemy;
    public Projectile projectile;
    public PlayerLives playerLives;
    //   private ProjectileSpawner spawner;

    public GameObject mainMenuPanel;
    public GameObject gameOverPanel;

    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        //  spawner = FindObjectOfType<ProjectileSpawner>();

        player.speed = 0;
      //  enemy.speed = 0;

        mainMenuPanel.SetActive(true);
        isGameOver = true;
    }

    public void PlayGame()
    {
        player.speed = 5f;
      //  enemy.speed = 2f;

        mainMenuPanel.SetActive(false);
        isGameOver = false;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
       // enemy.speed = 0;
        isGameOver = true;
    }
    public bool IsGameOver()
    {
        return isGameOver;
    }
    public void Restart()
    {
        //gameOverPanel.SetActive(false);
        //mainMenuPanel.SetActive(true);

        //playerLives.lives = 3;
        //for (int i = 0; i < playerLives.livesUI.Length; i++)
        //{
        //    if (i <playerLives.lives)
        //    {
        //       playerLives.livesUI[i].enabled = true;

        //    }
        //}
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
