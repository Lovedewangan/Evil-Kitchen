using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnWayPoints : MonoBehaviour
{

    public List<GameObject> waypoints;
    public float wait = 5f;
    public float speed = 30;
    public int index = 0;
    private bool isLoop = false;

    public float time = 0f;
    public bool stop;
    public int indexToStopAt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   // public bool shouldRotate = true;

    void Update()
    {
        Vector3 destination = waypoints[index].transform.position;
       /* if (index >= 13 && shouldRotate)
        {
            transform.Rotate(Vector3.up, -90.0f);
            shouldRotate = false;
        }*/

        if (!stop)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, waypoints[index + 1].transform.position, speed * Time.deltaTime);
            transform.position = newPos;
        }

        float distance = Vector3.Distance(transform.position, destination);
        if (transform.position == waypoints[index + 1].transform.position)
        {
            index++;
        }

        if (index == indexToStopAt)
        {
            time += Time.deltaTime;

            if (time < wait)
            {
                stop = true;
            }

            if (time >= wait)
            {
                stop = false;
                time = 0f;
                index++;
            }
        }
        if(index == 23)
        {
            stop = true;
            index = 0;
        }
        else
        {
            if (isLoop)
            {
                index = 0;
            }
        }
    }
}
