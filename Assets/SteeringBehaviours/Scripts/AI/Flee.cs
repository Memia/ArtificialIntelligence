using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    public class Flee : SteeringBehaviour
    {
        public Transform target;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public override Vector3 GetForce()
        {
            //Get direction to target
            Vector3 direction = owner.transform.position +(owner.transform.position - target.position).normalized;
            //or use:  velocity.Normalize() instead of wrapping it in brackets and add .normalized;
            return direction * owner.maxSpeed ;
         
        }

    }
}

