using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    public GameObject GameOverText;
    public GameObject RestartButton;
    public bool playing;
    public GameObject StartButton;
    public GameObject YouWinText;
    public GameObject GB;

    void Start()
    {
        GameOverText.SetActive(false);
        RestartButton.SetActive(false);
        playing = false;
    }
 
    public void StartGame()
    {
        playing = true;
        StartButton.SetActive(false);
    }
    


}