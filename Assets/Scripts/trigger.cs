using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    [SerializeField] private GameObject Body;

    private void OnTriggerEnter(Collider other)
    {
        Canvas.SetActive(true);
        Debug.Log("Spawnned");
        // Position the Canvas above the character's head
        Canvas.transform.SetParent(Body.transform, false); // Parent to the character's Body GameObject
        Canvas.transform.localPosition = new Vector3(0, 90f, 0); // Adjust offset as needed
    }

    private void OnTriggerExit(Collider other)
    {
        Canvas.SetActive(false);
    }
}
