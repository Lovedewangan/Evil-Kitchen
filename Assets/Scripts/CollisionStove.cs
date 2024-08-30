using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionStove : MonoBehaviour
{
    [SerializeField] private KitchenObjectSo kitchenObjectSO;
    //[SerializeField] private Transform counterTopPoint;

    //public Transform kitchenObjectTransform;

    //[SerializeField] private Transform ingridientGrabPoint;
    void Start()
    {

    }

    // Update is called once per frame

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Triger");
        if (other.tag == "Player Body")
        {
            Debug.Log("Player Entered");
            if (Input.GetKey(KeyCode.E))
            {
               
                    Destroy(PlayerController.instance.selectedObject);
                    Debug.Log("Trigger2");
               
                //ResetPosition.Ingridient = kitchenObjectTransform.gameObject;

            }
        }
        /*if (Input.GetKey(KeyCode.E))
        {
            
            else
            {
                Transform tomatoTransform2 = Instantiate(tomatoPrefab, counterTopPoint);
                tomatoTransform2.position = counterTopPoint.position;
                Debug.Log("Trigger1");
            }
        }*/


    }
}
