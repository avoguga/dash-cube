using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int Score;
    public TMP_Text ScoreText;
    void Start()
    {
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        // Por enquanto � 0, j� que eu n�o criei nenhuma outra Scene
        SceneManager.LoadScene(0);
    }
}
