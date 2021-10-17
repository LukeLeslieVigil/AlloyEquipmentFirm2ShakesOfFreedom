using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    private ScoreCounter scoreCounter;
    private GameObject gameController;

    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
        scoreCounter = gameController.GetComponent<ScoreCounter>();
    }
    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
        scoreCounter.playerScore = 0;
        scoreCounter.enemyScore = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
