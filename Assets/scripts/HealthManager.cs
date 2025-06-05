using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UIMANAGER uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIMANAGER>();
        maxHealthPoints = 100;
        healthPoints = maxHealthPoints;
    }

    public void TakeDamage(int damagePoints)
    {
        if(healthPoints <= damagePoints)
        {
            return;
        }

        healthPoints -= damagePoints;
        uiManager.UpdateHealth(healthPoints);
    }

}
