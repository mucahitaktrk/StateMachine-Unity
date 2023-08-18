using System;
using _GAME_.Script.Controller;
using _GAME_.Script.PlayerController.State;
using UnityEngine;

namespace _GAME_.Script.PlayerController
{
    public class PlayerMachine : MonoBehaviour
    {
        private PlayerState _currentState;
        
        public PlayerState IdleState { get; private set; }
        public PlayerState MoveState { get; private set; } 
        public PlayerState TalkState { get; private set; }
        [field: SerializeField] public Animator PlayerAnimator { get; private set; }
       
        [field: SerializeField] public CharacterController PlayerController { get; private set; }

        private void Awake()
        {
            IdleState = new IdleState(this);
            MoveState = new MoveState(this);
            TalkState = new TalkState(this);
        }

        private void OnEnable()
        {
            StateController.OnSetState += SetState;
        }

        private void OnDisable()
        {
            StateController.OnSetState -= SetState;
        }

        private void Update()
        {
            _currentState.Tick();
        }

        private void FixedUpdate()
        {
            _currentState.FixedTick();
        }
        
        private void SetState(PlayerState playerState)
        {
            _currentState?.Exit();
            _currentState = playerState;
            _currentState?.Enter();
        }
    }
}
