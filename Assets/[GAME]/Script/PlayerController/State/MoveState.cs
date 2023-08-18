using UnityEngine;

namespace _GAME_.Script.PlayerController.State
{
    public class MoveState : PlayerState
    {
        private static readonly int Move = Animator.StringToHash("Move");

        public MoveState(PlayerMachine playerMachine) : base(playerMachine)
        {
        }

        public override void Enter()
        {
            PlayerMachine.PlayerAnimator.SetBool(Move,true);
        }

        public override void Tick()
        {
            
        }

        public override void FixedTick()
        {
            PlayerMachine.PlayerController.Move(Vector3.up * -.1f + Vector3.forward * Time.deltaTime);
        }

        public override void Exit()
        {
            PlayerMachine.PlayerAnimator.SetBool(Move,false);
        }
    }
}