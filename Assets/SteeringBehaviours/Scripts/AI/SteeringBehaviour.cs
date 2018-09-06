﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SteeringBehaviours
{
    [RequireComponent(typeof(AIAgent))]
    public abstract class SteeringBehaviour : MonoBehaviour
    {//"SteeringBehaviour" will only work if attached to AI agent

        // The amount of influence the behaviour has over the other
        public float weighting;
        //Reference to AIAgent owner of behaviour
        public AIAgent owner;
        // Use this for initialization
        private void Awake()
        {

        }
        public virtual Vector3 GetForce()
        {

          return Vector3.zero;
        }

    }
}
