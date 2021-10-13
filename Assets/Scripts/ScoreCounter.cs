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

    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(playerScore);
    }
}
