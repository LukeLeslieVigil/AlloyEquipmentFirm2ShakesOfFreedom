using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCollect : MonoBehaviour
{
    [SerializeField]
    private GameObject shake;
    [SerializeField]
    private GameObject gameController;

    private ScoreCounter scoreCounter;
    private ShakeSpawner shakeSpawner;

    //Looks for the game controller then sets it so that it can
    //parse the number of shakes collected to another script.
    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
        scoreCounter = gameController.GetComponent<ScoreCounter>();
        shakeSpawner = gameController.GetComponent<ShakeSpawner>();
    }

    //Checks which tag enters the collider so it can give the correct
    //point value to the player or enemy,
    //then moves the shake.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            scoreCounter.playerScore += 1;
        }
        else if (other.tag == "Enemy")
        {
            scoreCounter.enemyScore += 1;
        }
        shakeSpawner.MoveShake();
    }
}
