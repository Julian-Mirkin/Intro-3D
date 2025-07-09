using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessague;
    public bool canInteract;
    public MercaderiaScript mercaderia;

    private void Start()
    {
        UIInteractionMessague.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.W))
        {
            if (canInteract)
            {
                Destroy(mercaderia.gameObject);
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
