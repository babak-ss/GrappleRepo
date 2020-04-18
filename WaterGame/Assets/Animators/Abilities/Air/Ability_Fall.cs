﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace masterFeature
{
    [CreateAssetMenu(fileName = "_Fall", menuName = "Abilities/Aerial/Fall")]
    public class Ability_Fall : StateData
    {
        public override void enterAbility(StateBase stateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            Controller controller = stateBase.getController(animator);
            // reset state parameters
            animator.SetBool(stateBase.getAnimatorHashCodes().collidedDown, false);
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        public override void updateAbility(StateBase stateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            Controller controller = stateBase.getController(animator);
            // Initialise Speeds for state
            controller.setInputSpeed(Controller.SpeedX.run, Controller.SpeedY.rise);

            // Set input velocity
            changeVelocityX(animator, controller, stateBase.getAnimatorHashCodes());
            changeVelocityY(animator, controller, stateBase.getAnimatorHashCodes());
        }

        public override void exitAbility(StateBase stateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }
}