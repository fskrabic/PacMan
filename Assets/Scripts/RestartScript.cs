using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{


public void RestartGame()
 {
 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }


}