using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public GameController gameController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        gameController.Score++;
        gameController.ScoreText.text = gameController.Score.ToString();
    }
}
