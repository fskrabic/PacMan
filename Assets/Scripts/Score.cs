using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int value = 1;
    public int score;
    private GameObject gc;
    private GameObject gb;
    //private GameObject[] dots;
    //public int broj;

    // Start is called before the first frame update
    void Start()
    {
       // dots = GameObject.FindGameObjectsWithTag("dot");
        gb = GameObject.FindWithTag("ghost");
        gc = GameObject.FindWithTag("proba");
        score = 0;
        scoreText.text = "Score:\n" + score;
    }
    void OnTriggerEnter2D(Collider2D co)
    {
            score += value;
            scoreText.text = "Score:\n" + score;
            Destroy(co);
    }
    void Update() {
        //broj = dots.Length;

        if (score >= 288) {
            gc.GetComponent<GameController>().GB.SetActive(true);
            gc.GetComponent<GameController>().playing = false;
            gc.GetComponent<GameController>().YouWinText.SetActive(true);
            gc.GetComponent<GameController>().RestartButton.SetActive(true);
        }
    }
}
