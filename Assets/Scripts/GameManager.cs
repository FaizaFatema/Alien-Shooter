using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject mainGame;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuPanel.SetActive(true);
    }
    public void PlayGame()
    {
        mainMenuPanel.SetActive(false);
        mainGame.SetActive(true);
    }
}
