using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class WaypointEnemy : MonoBehaviour

{
    public Transform waypointParent;
    public NavMeshAgent agent;

    //Creates a collection(array) of transforms
    private Transform[] waypoints;
    private int currentIndex = 1;


    void Start()
    {
        //Getting children of waypointParent
        waypoints = waypointParent.GetComponentsInChildren<Transform>();
    }


    void Update()
    {
   
        Transform point = waypoints[currentIndex];
        float distance = Vector3.Distance(transform.position, point.position);
        
        if (distance < 10.10f)
        {
          
            // currentIndex = currentIndex +1
            currentIndex++;
        }//makes the index 1 if index reach/exceeds range, use this to create cycle
       if (currentIndex >= waypoints.Length)
        {
            currentIndex = 1;
        }
        agent.SetDestination(point.position);
        //transform.position = Vector3.MoveTowards(transform.position, point.position, 0.1f);
    }
}
