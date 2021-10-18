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

    //Looks for the game controller then sets it so that it can
    //parse the number of shakes collected to another script.
    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
        scoreCounter = gameController.GetComponent<ScoreCounter>();
    }

    //Checks which tag enters the collider so it can give the correct
    //point value to the player or enemy,
    //then destroys the shake.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            scoreCounter.playerScore += 1;
            //other.transform.localPosition = new Vector3(Random.Range(-3.5f, 3.5f), 0, Random.Range(-3.5f, 3.5f));
        }
        else if (other.tag == "Enemy")
        {
            scoreCounter.enemyScore += 1;
        }
        //Destroy(shake);
    }
}
