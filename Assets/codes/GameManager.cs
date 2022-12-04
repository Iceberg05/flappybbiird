using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText; public Text highscoreText;
    int score = 0;
    int highscore = 0;
    AudioSource puansesi;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update void Start()

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + "";
        highscoreText.text = "" + highscore.ToString();
        puansesi = GetComponent<AudioSource>();
    }


    public void AddPoint()
    {
        puansesi.Play();
        score += 1;
        scoreText.text = score.ToString() + ""; if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}




