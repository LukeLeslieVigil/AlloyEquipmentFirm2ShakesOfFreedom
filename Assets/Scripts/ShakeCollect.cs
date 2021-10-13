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

    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController");
        scoreCounter = gameController.GetComponent<ScoreCounter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            scoreCounter.playerScore += 1;
        }
        Destroy(shake);
    }
}
