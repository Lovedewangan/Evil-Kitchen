using UnityEngine;
using UnityEngine.UI;

public class CollisionUIManager : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;

    void Start()
    {
        Canvas.SetActive(false); // Hide the UI layout at the beginning
    }

    private void OnColliderEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trig")
        {
            Canvas.SetActive(true);

        }
    }

    private void OnColliderExit(Collision collision)
    {
        if (collision.gameObject.tag == "Trig")
        {
            Canvas.SetActive(false);
        }
    }
}
