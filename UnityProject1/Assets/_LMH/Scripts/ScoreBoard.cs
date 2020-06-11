using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private Text txt;
    public int score = 0;
    public int highScore;
    public static ScoreBoard instance = null;

    private void Awake()
    {
        highScore = 0;
        highScore = PlayerPrefs.GetInt("HIGHS");
        if (instance == null)instance = this;
        else if(instance != this)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "SCORE : " + score.ToString() +"\n"+ "HIGH : " + highScore.ToString();
    }

    public void AddScore()
    {
        score++;
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HIGHS", highScore);
        }
    }
}
