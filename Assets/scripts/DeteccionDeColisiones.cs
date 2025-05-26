using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;
    public MercaderiaScript mercaderiaScript;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<MercaderiaScript>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        if(collision.gameObject.name == "Player")
        {
        Destroy(gameObject);
            scoreManager.addScore(mercaderiaScript.scorePoints);
        }
    }

}