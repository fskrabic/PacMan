using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour {
    public int pacman_lives = 3;
    public Text livesText;
    public bool p = false;
    private GameObject gc;
    private GameObject go;
    private GameObject rs;
   

    void Start() {
        gc = GameObject.FindWithTag("proba");
        livesText.text = "Lives:\n" + pacman_lives;
    }

    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "crveni" ||co.name == "plavi" || co.name == "zuti" || co.name == "rozi" ) {
            if (pacman_lives > 0) {
                pacman_lives -= 1;
                livesText.text = "Lives:\n" + pacman_lives;
            }
        }
    }
    void Update() {
        if (pacman_lives == 0) {
            gc.GetComponent<GameController>().playing = false;
            gc.GetComponent<GameController>().GameOverText.SetActive(true);
            gc.GetComponent<GameController>().RestartButton.SetActive(true);
            Destroy(gameObject);
        }
    }
   
}