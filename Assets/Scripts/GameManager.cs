using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController player;
    public EnemyMovement enemy;
    public Projectile projectile;
    
    public GameObject mainMenuPanel;
   
    // Start is called before the first frame update
    void Start()
    {
        player.speed = 0;
        enemy.speed = 0;
        
        mainMenuPanel.SetActive(true);
        
        
    }
    public void Update()
    {
       
    }
    public void PlayGame()
    {
        player.speed = 5f;
        enemy.speed = 2f;
       
        mainMenuPanel.SetActive(false);
    }
}
