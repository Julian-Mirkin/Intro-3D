using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        if(collision.gameObject.name == "Player")
        {
        Destroy(gameObject);
        }
    }

}