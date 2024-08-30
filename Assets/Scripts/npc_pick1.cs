using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_pick1 : MonoBehaviour
{
    public MoveOnWayPoints moveonwaypoint;

    
    public void Go()
    {
        if (Recipes.instance.meatBurgerCounter == 1)
        {
            moveonwaypoint.index = 18;
            moveonwaypoint.stop = false;
        }
    }

}