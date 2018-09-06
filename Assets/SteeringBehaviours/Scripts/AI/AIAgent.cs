using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace SteeringBehaviours
{
    public class AIAgent : MonoBehaviour
    {
        #region Variables

        private Vector3 point;
        public float maxSpeed;
        public float maxDistance;
        public bool updatePosition;
        public bool updateRotation;
        public Vector3 velocity;

        private Vector3 force;
        private List<SteeringBehaviour> behaviours;
        private NavMeshAgent agent;
        #endregion

        void Awake()
        {

        }
        void ComputeForces()
        {
        }
        void ApplyVelocity()
        {

        }
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
