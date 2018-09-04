using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace SteeringBehaviours
{
    public class AIAgent : MonoBehaviour
    {
        #region Variables
        public NavMeshAgent agent;
        private Vector3 point;
        #endregion


        // Update is called once per frame
        void Update()
        {
            if (point.magnitude > 0)
            {   //Set the agent's destination to that point
                agent.SetDestination(point);
            }

        }
        public void SetTarget(Vector3 point)
        {   //this defines what you are refering to
            this.point = point;
        }
    }

}
