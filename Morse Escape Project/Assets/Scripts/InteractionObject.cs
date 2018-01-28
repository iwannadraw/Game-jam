/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {

    public GameObject currentInterObj = null;

    void OnTriggerEnter2D(Collider2d other)
    {
        if (other.CompareTag("interObject")) {
            text = "This is item";

            currentInterObj = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("interObject"))
        {   
            if(other.GameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            
            
        }
    }
}
*/