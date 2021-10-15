using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public int playerScore = 0;
    public int enemyScore = 0;

    [SerializeField]
    private TMP_Text playerScoreTracker;
    [SerializeField]
    private TMP_Text enemyScoreTracker;
    [SerializeField]
    private GameObject YouWinScreen;
    [SerializeField]
    private GameObject YouLoseScreen;

    void Update()
    {
        //Debug.Log(playerScore);
        ScoreTracker();
    }

    //Changes the text based on shakes collected,
    //with the number being parsed from the ShakeCollect script.
    //Then, it checks if the number of shakes collected is equal or greater than 10
    //for both the player and enemy, setting the win / lose screen accordingly.
    private void ScoreTracker()
    {
        playerScoreTracker.text = "Player Score: " + playerScore;
        enemyScoreTracker.text = "Enemy Score: " + enemyScore;

        if (playerScore >= 10)
        {
            YouWin();
        }
        else if (enemyScore >= 10)
        {
            YouLose();
        }
    }

    //Pauses the game, sets the win screen
    private void YouWin()
    {
        Time.timeScale = 0f;
        YouWinScreen.SetActive(true);
    }

    //Pauses the game, sets the lose screen
    private void YouLose()
    {
        Time.timeScale = 0f;
        YouLoseScreen.SetActive(true);
    }
}
