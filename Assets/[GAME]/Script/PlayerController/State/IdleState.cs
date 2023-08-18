using UnityEngine;

namespace _GAME_.Script.PlayerController.State
{
    public class IdleState : PlayerState
    {
        private static readonly int Idle = Animator.StringToHash("Idle");

        public IdleState(PlayerMachine playerMachine) : base(playerMachine)
        {
        }

        public override void Enter()
        {
            PlayerMachine.PlayerAnimator.SetBool(Idle,true);
        }

        public override void Tick()
        {
            
        }

        public override void FixedTick()
        {
            PlayerMachine.PlayerController.Move(Vector3.up * -.1f);
        }

        public override void Exit()
        {
            PlayerMachine.PlayerAnimator.SetBool(Idle,false);
        }
    }
}