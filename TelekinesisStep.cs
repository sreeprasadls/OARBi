using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NextMind.Examples.Steps
{
    public class TelekinesisStep : AbstractStep
    {

        [SerializeField]
        private Transform objectA = null;

        /// <summary>
        /// The current force to apply on the cube.
        /// </summary>
        private float strength;

        public override void OnEnterStep()
        {
            // Place the cube at the initial position each time this step is activated.
            //StartCoroutine(SetToInitialPosition());

            // Position objects
            //objectA.localPosition = Vector3.up * 0.5f;
            //objectA.localEulerAngles = new Vector3(5, 5, 5);
        }

        //private IEnumerator SetToInitialPosition(float height = 0.5f, float delay = 0f)
        //{
        //    if (delay > 0)
        //    {
        //        yield return new WaitForSeconds(delay);
        //    }

        //    // Reset rigidbody's physics values.
        //    strength = 0;
        //    //objectA.velocity = Vector3.zero;
        //    //objectA.angularVelocity = Vector3.zero;

        //    // Reset transform to the right position.
        //    objectA.localPosition = Vector3.up * height;
        //    objectA.localEulerAngles = 5 * Vector3.one;
        //}

    }
}
