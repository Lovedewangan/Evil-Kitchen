using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Recipes : MonoBehaviour
{
    public DishSO dishSO;

    public Transform dishTransform;

    public Transform dishFinalPoint;

    public int garlicCounter = 0;
    public int tomatoCounter = 0;
    public int breadCounter = 0;
    public int bunCounter = 0;
    public int meatCounter = 0;
    public int cabbageCounter = 0;
    public int garlicBreadCounter = 0;
    public int meatBurgerCounter = 0;
    public int cabbageGarlicFryCounter = 0;
    public int tomatoGarlicToastCounter = 0;

    public NewBehaviourScript progressBarInstance;

    public GameObject selectedObject;

    public static Recipes instance;
    

    void Start()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //Garlic Bread
        if(breadCounter == 1 && garlicCounter == 1)
        {
            breadCounter = 0;
            garlicCounter = 0;
            garlicBreadCounter++;
            Invoke("callFunction", 5.0f);
            Invoke("InstantiateDish", 8.0f);
            

        }

        //Meat Burger
        if(meatCounter == 1 && bunCounter == 1 && cabbageCounter == 1)
        {
            meatCounter = 0;
            cabbageCounter = 0;
            bunCounter = 0;
            meatBurgerCounter++;
            Invoke("callFunction", 5.0f);
            Invoke("InstantiateDish", 8.0f);

        }

        //Cabbage Garlic Fry
        if (meatCounter == 1 && garlicCounter == 1 && cabbageCounter == 1)
        {
            meatCounter = 0;
            garlicCounter= 0;
            cabbageCounter = 0;
            cabbageGarlicFryCounter++;
            Invoke("callFunction", 5.0f);
            Invoke("InstantiateDish", 8.0f);

        }

        //Tomato Cabbage Toast
        if(breadCounter == 1 && tomatoCounter == 1 && cabbageCounter == 1)
        {
            breadCounter = 0;
            tomatoCounter = 0;
            cabbageCounter = 0;
            tomatoGarlicToastCounter++;
            Invoke("callFunction", 5.0f);
            Invoke("InstantiateDish", 8.0f);

        }
    }
    void callFunction()
    {
        progressBarInstance.startFunction();
    }
    void InstantiateDish()
    {
        dishTransform = Instantiate(dishSO.prefab, dishFinalPoint);
        dishTransform.position = dishFinalPoint.position;
        Recipes.instance.selectedObject = dishTransform.gameObject;
    }
}