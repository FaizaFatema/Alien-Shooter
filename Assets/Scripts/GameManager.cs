using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    public PlayerController player;
    public EnemyMovement enemy;
    public Projectile projectile;
   // public ProjectileSpawner spawner;
    
    public GameObject mainMenuPanel;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        player.speed = 0;
        enemy.speed = 0;
        
        mainMenuPanel.SetActive(true);
    }
   
    public void PlayGame()
    {
        player.speed = 5f;
        enemy.speed = 2f;
       
        mainMenuPanel.SetActive(false);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        enemy.speed = 0;
       // ProjectileSpawner.instance.spawnTimer = 1;
    }
}
