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

        protected override void Update()
        {
            base.Update(); // Calls the base class's Update
        }

        private void LateUpdate()
        {
            print("Seek Called!");

        }
        public override Vector3 GetForce()
        {
            //Get direction to target
            Vector3 direction = (target.position - owner.transform.position).normalized;
            //or use:  velocity.Normalize() instead of wrapping it in brackets and add .normalized;
            return direction * owner.maxSpeed;
        }
    }
}
