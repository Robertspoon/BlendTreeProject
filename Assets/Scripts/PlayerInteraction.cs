using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private GameObject currentInterObj = null;

    [SerializeField]
    private InteractionObject currentInterObjScript = null;


    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && currentInterObj == true)
        {
            CheckInteraction();
        }
    }

    void CheckInteraction()
    {
        Debug.Log("This is a " + currentInterObj);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = null;
            currentInterObjScript = null;   
        }
    }


}
