using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    public class AIAgentDirector : MonoBehaviour
    {
        public AIAgent[] agents;
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

                //Ray casts from the camera
                Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(camRay, out hit, 1000f))
                {
                    foreach (var agent in agents)

                    {
                        Flee flee = agent.GetComponent<Flee>();
                        Seek seek = agent.GetComponent<Seek>();
                        placeholderPoint.position = hit.point;

                        if (seek)
                            seek.target = placeholderPoint;
                        if (flee)
                            flee.target = placeholderPoint;
                    }
                }
            }


        }
    }
}
