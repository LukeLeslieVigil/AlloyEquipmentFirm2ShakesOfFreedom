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


    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log(playerScore);
        ScoreTracker();
    }

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

    private void YouWin()
    {
        Time.timeScale = 0f;
        YouWinScreen.SetActive(true);
    }

    private void YouLose()
    {
        Time.timeScale = 0f;
        YouLoseScreen.SetActive(true);
    }
}
