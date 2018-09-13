using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    public class AIAgentDirector : MonoBehaviour
    {
        public AIAgent agent;
        public Transform placeholderPoint;
        private void OnDrawGizmosSelected()
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Draw a line from the
            // - start; where the ray starts from
            // - end; where the ray is going
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(camRay.origin, camRay.origin + camRay.direction * 1000f);
            
        }

        // Use this for initialization
        void FixedUpdate()
        {
            if (Input.GetMouseButton(0))
            {
                //Try to get seek component on agent
                Seek seek = agent.GetComponent<Seek>();
                //if seek is not null
                if (seek)
                {
                    //Ray casts from the camera
                    Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(camRay, out hit, 1000f))
                    {
                        //Update the transform's position
                        placeholderPoint.position = hit.point;
                        //Update seek's target (which you might not need to do)
                        seek.target = placeholderPoint;
                    }
                }
            }

        }
    }
}
