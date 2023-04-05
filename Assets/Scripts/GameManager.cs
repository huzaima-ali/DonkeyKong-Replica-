using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void UpdateScore(int ScoreToAdd)
    {
        Score += ScoreToAdd;
        ScoreText.text = "Score: " + Score;
    }

    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
    }
}
