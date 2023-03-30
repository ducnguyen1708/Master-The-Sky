using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public static int Score;
    [SerializeField] private TMP_Text scoreText; 
    [SerializeField] private TMP_Text _HighScore;
    void Start()
    {
        int hiScore = PlayerPrefs.GetInt("high-score", 0);
        scoreText.text = $"Score:{Score}";
        _HighScore.text = $"High Score: {hiScore}";
        Debug.Log(hiScore);
    }
    public void OnlcickMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OnclickReplay()
    {
        SceneManager.LoadScene("Game");
    }
}
