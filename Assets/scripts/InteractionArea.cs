﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public bool canInteract;
    public GameObject UIInteractionMessague;
    public MercaderiaScript mercaderia;

    public ScoreManager scoreManager;

    private void Start()
    {
        UIInteractionMessague.SetActive(false);

        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.E)||Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.W))
        {
            if (canInteract)
            {
                Destroy(mercaderia.gameObject);
                scoreManager.addScore(mercaderia.scorePoints);
                EndInteraction();
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        mercaderia = other.GetComponent<MercaderiaScript>();
        if (mercaderia)
        {
            UIInteractionMessague.SetActive(true);
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UIInteractionMessague.SetActive(false);
        canInteract = false;
        mercaderia = null;
    }
        
    void EndInteraction()
    {
        UIInteractionMessague.SetActive(false);
        canInteract = false;
        mercaderia = null;
    }
}
