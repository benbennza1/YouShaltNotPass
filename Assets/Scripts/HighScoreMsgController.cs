﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreMsgController : MonoBehaviour {

    public Text score;

    private GameManager gameManager;
	// Use this for initialization
	void Start () {
        gameManager = FindObjectOfType<GameManager>();
        int playerscore = gameManager.getScore();
        gameManager.enterScore(playerscore);

        int[] highscores = gameManager.getHighscores();
        for (int i = 0;i<highscores.Length;i++)
        {
            score.text+="\n" +"#" +(i+1)+": " + highscores[i];
        }
        score.text += "\n Average score: " + gameManager.getAverageScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}