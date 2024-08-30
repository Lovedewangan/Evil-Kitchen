using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_pick2 : MonoBehaviour
{
    public MoveOnWayPoints moveonwaypoint;

    
    public void Go()
    {
        if (Recipes.instance.cabbageGarlicFryCounter == 1)
        {
            moveonwaypoint.index = 18;
            moveonwaypoint.stop = false;
        }
       
    }

}