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
        private SteeringBehaviour[] behaviours;
        private NavMeshAgent agent;
        #endregion

        void Awake()
        {
            behaviours = GetComponents<SteeringBehaviour>();
            agent = GetComponent<NavMeshAgent>();
        }
        void ComputeForces()
        {
            //Reset velocity
            velocity = Vector3.zero;
            //Loop through each behaviour
            for (int i = 0; i < behaviours.Length; i++)
            {
                //Get force from behaviour
                Vector3 force = behaviours[i].GetForce();
                //Add it to velocity
                velocity += force;
            }
        }
        void ApplyVelocity()
        {
            //Get an offset position as new target
            Vector3 point = transform.position + velocity * Time.deltaTime;
            //Apply velocity to transform
            agent.SetDestination(point);
        }
        // Update is called once per frame
        void Update()
        {
            ComputeForces();
            ApplyVelocity();

        }
    }

}
