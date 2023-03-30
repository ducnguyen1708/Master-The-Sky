using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TMP_Text scoreText;
    private int _score = 0;
    private void Awake() {
        Instance = this;
    }

    public void GameOver()
    {
        GameOverMenu.Score = _score;
        SceneManager.LoadScene("GameOver");
        int hiScore = PlayerPrefs.GetInt("high-score", 0);
        if(_score > hiScore)
        {
            PlayerPrefs.GetInt("high-score", _score);
        }
    }
    public void GainScore()
    {
        _score += 1;
        scoreText.text = $"Score: {_score}";
    }
}
