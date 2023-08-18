using System;
using _GAME_.Script.PlayerController;
using _GAME_.Script.PlayerController.State;
using UnityEngine;
using UnityEngine.UI;

namespace _GAME_.Script.Controller
{
    public class StateController : MonoBehaviour
    {
        [SerializeField] private PlayerMachine player;
        
        [SerializeField] private Button idleButton;
        [SerializeField] private Button moveButton;
        [SerializeField] private Button talkButton;

        public static event Action<PlayerState> OnSetState;
        private void OnEnable()
        {
            idleButton.onClick.AddListener(() =>
            {
                OnSetState?.Invoke(player.IdleState);
            });
            
            moveButton.onClick.AddListener(() =>
            {
                OnSetState?.Invoke(player.MoveState);
            });
            
            talkButton.onClick.AddListener(() =>
            {
                OnSetState?.Invoke(player.TalkState);
            });
        }

        private void Start()
        {
            OnSetState?.Invoke(player.IdleState);
        }
    }
}
