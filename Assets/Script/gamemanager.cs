using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    private int score = 0;
    public int winningScore = 10;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Lock the cursor and make it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();

        if (score >= winningScore)
        {
            TransitionToWinnerScene();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void TransitionToWinnerScene()
    {
        SceneManager.LoadScene("end");
    }
}
