﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace masterFeature
{
/*    [CreateAssetMenu(fileName = "_FallToGround", menuName = "Abilities/Ground/FallToGround")]
    public class Ability_FallToGround : StateData
    {
        [Range(0.001f, 0.1f)]
        public float energyBuildDuration;

        public override void enterAbility(StateBase stateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            Controller controller = stateBase.getController(animator);
            // Set environment
            controller.env = Controller.EnvState.Ground;
            animator.SetInteger(stateBase.getAnimatorHashCodes().environment, Controller.EnvState.Ground.GetHashCode());

            // Initialise Speeds for state
            controller.setInputSpeed(Controller.SpeedY.idle);

            // hit ground
            controller.envVelocity.y = 0;
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        public override void updateAbility(StateBase stateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            Controller controller = stateBase.getController(animator);
        }

        public override void exitAbility(StateBase stateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            Controller controller = stateBase.getController(animator);
            // Energy released
            animator.SetBool(stateBase.getAnimatorHashCodes().energyBuilt, false);

            animator.SetBool(stateBase.getAnimatorHashCodes().grounded, false);
        }
    }*/
}