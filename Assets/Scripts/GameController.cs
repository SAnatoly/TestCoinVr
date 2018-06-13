using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text ScoreText;
    int scores;
    public static GameController instance;
	// Use this for initialization
	void Start ()
    {
        instance = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChangeScore(int score)
    {
        scores += score;
        ScoreText.text = scores.ToString();
    }
}
