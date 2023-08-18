using UnityEngine;

namespace _GAME_.Script.PlayerController.State
{
    public class TalkState : PlayerState
    {
        private static readonly int Talk = Animator.StringToHash("Talk");

        public TalkState(PlayerMachine playerMachine) : base(playerMachine)
        {
        }

        public override void Enter()
        {
            PlayerMachine.PlayerAnimator.SetBool(Talk, true);
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
            PlayerMachine.PlayerAnimator.SetBool(Talk, false);
        }
    }
}