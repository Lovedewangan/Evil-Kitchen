using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public KitchenObjectSo kitchenObjectSO;
    
    public Transform kitchenObjectTransform;

    public Transform ingridientGrabPoint;
    void Start()
    {
        
    }



    void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger");
        if (other.tag == "Player Body")
        {
            Debug.Log("Player Entered");
            if (Input.GetKey(KeyCode.E))
            {
                if (kitchenObjectTransform == null)
                {
                    if (PlayerController.instance.selectedObject == null)
                    {
                        if (this.gameObject.tag == "Garlic")
                        {
                            Recipes.instance.garlicCounter++;
                        }
                        if (this.gameObject.tag == "Bun")
                        {
                            Recipes.instance.bunCounter++;
                        }
                        if (this.gameObject.tag == "Meat")
                        {
                            Recipes.instance.meatCounter++;
                        }
                        if (this.gameObject.tag == "Bread")
                        {
                            Recipes.instance.breadCounter++;
                        }
                        if (this.gameObject.tag == "Cabbage")
                        {
                            Recipes.instance.cabbageCounter++;
                        }
                        if (this.gameObject.tag == "Tomato")
                        {
                            Recipes.instance.tomatoCounter++;
                        }
                        kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, ingridientGrabPoint);
                        kitchenObjectTransform.position = ingridientGrabPoint.position;

                        PlayerController.instance.selectedObject = kitchenObjectTransform.gameObject;
                        Debug.Log("Trigger2");
                    }
                }
            }
        }
    }
}
