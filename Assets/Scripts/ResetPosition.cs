using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject Player;
    public GameObject[] body;
    public GameObject Ingridient;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Ingridient != null)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Colliding");
                    foreach (GameObject go in body)
                    {
                        go.GetComponent<Rigidbody>().isKinematic = true;
                    }

                    Player.transform.position = new Vector3(StartPoint.transform.position.x, Player.transform.position.y, StartPoint.transform.position.z);
                    foreach (GameObject go in body)
                    {
                        go.GetComponent<Rigidbody>().isKinematic = false;
                    }
                    Ingridient.transform.parent = null;
                    Destroy(Ingridient);
                }
            }
           
            

        }
    }
}
