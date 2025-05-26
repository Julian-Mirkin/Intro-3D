using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public UIMANAGER uiManager;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        uiManager = FindObjectOfType<UIMANAGER>();
    }

    public void addScore()
    {
        score++;
        uiManager.UpdateScore(score);
    }

    public void addScore(int scorePoints)
    {
        score += scorePoints;
        uiManager.UpdateScore(score);
    }

}
