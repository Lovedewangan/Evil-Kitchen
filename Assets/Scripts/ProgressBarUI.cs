using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Image timer_linear_image;
    float time_remaining;
    public float max_time = 0.0f;
    internal int myVariable;
    public bool a;
    void Start()
    {
        time_remaining = 0;
    }

    public void startFunction()
    {
        a = true;
    }
    private void Update()
    {
        if(a==true) 
        {
        myFunction();
        }
    }

    public void myFunction() 
    {
        
        if (time_remaining < 3.5)
        {
            time_remaining += Time.deltaTime;
            timer_linear_image.fillAmount = time_remaining/3;
            
        }
        else
        {
           timer_linear_image.fillAmount = 0;
        }
        
    }
}
