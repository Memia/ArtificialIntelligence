using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SteeringBehaviours
{
    // Base Class 
    [RequireComponent(typeof(AIAgent))]
    public abstract class SteeringBehaviour : MonoBehaviour
    {//"SteeringBehaviour" will only work if attached to AI agent

        // The amount of influence the behaviour has over the other
        public float weighting;
        //Reference to AIAgent owner of behaviour
       [HideInInspector] public AIAgent owner;
        // Use this for initialization
        private void Awake()
        {
            owner = GetComponent<AIAgent>();
        }
        protected virtual void Update()
        {

        }

        private void LateUpdate()
        {
            print("SteeringBehaviour Called!");

        }
        public virtual Vector3 GetForce()
        {

          return Vector3.zero;
        }

    }
}
