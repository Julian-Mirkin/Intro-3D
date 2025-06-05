using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtHealth;

    void Start()
    {
        
    }

    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }
    public void UpdateHealth(int health)
    {
        txtHealth.text = health.ToString();
    }
}
