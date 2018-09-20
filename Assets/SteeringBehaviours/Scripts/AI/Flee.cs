using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    public class Flee : SteeringBehaviour
    {
        public Transform target;

        public override Vector3 GetForce()
        {
            Vector3 force = Vector3.zero;
            if (target)
            {
                //Get direction to target
                Vector3 direction = (owner.transform.position - target.position).normalized;
                //or use:  velocity.Normalize() instead of wrapping it in brackets and add .normalized;
                return direction * owner.maxSpeed;
            }
            return force;
        }

    }
}

