using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public HealthManager healthManager;

    public void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            healthManager.TakeDamage(10);
        }
    }

}