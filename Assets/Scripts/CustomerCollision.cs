using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Trigger");
        if (other.tag == "Player Body")
        {
            //Debug.Log("Player Entered");
            if (Input.GetKey(KeyCode.Mouse0))
            {

                Destroy(Recipes.instance.selectedObject);
                //Debug.Log("Trigger2");

                //ResetPosition.Ingridient = kitchenObjectTransform.gameObject;

            }
        }
    }
}