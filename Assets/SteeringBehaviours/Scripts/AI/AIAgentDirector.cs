using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    public class AIAgentDirector : MonoBehaviour
    {
        public AIAgent agent;

        // Use this for initialization
        void FixedUpdate()
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(camRay, out hit, 1000f))
            {
                agent.SetTarget(hit.point);
            }
        }
       
        // Update is called once per frame
        void Update()
        {

        }
    }
}
