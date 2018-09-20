using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SteeringBehaviours
{
    // Derrived class of "SteeringBehaviour"
    public class Seek : SteeringBehaviour
    {
        public Transform target;
        public float stoppingDistance;

        public override Vector3 GetForce()
        {
            Vector3 force = Vector3.zero;
            if (target)
            {
                //Get direction to target
                Vector3 direction = (target.position - owner.transform.position).normalized;
                //or use:  velocity.Normalize() instead of wrapping it in brackets and add .normalized;
                force = direction * owner.maxSpeed;
                
            }
            return force;
        }
    }
}
