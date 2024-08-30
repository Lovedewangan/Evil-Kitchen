using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_pick : MonoBehaviour
{
    public MoveOnWayPoints moveonwaypoint;

    
    public void Go()
    {
        if(Recipes.instance.garlicBreadCounter == 1) { 
            moveonwaypoint.index = 18;
            moveonwaypoint.stop = false;
        }
    }

}