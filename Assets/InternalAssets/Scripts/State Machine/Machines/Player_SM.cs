using System;
using UnityEngine;
using StateManager;
[RequireComponent(typeof(PlayerComponents), typeof(Rigidbody), typeof(CapsuleCollider))]
    public class Player_SM: MonoBehaviour
    {
        private PlayerComponents _playerComponents;
        private StateMachine _SM;
        private Player_Hide _hide;
        private Player_Move _move;

        private bool isMoving()
        {
            return _playerComponents.Joystick.Horizontal != 0 || _playerComponents.Joystick.Vertical != 0;
        }
        
        private void Awake()
        {
            InitComponents();
            InitStates();
        }

        private void Start()
        {
            _SM.Initialize(_hide);
        }

        private void FixedUpdate()
        {
            _SM.CurrentState.Update();
            
            if (isMoving())
            {
                _SM.ChangeState(_move);
                _move._joystick = _playerComponents.Joystick;
            }
            else
            {
                _SM.ChangeState(_hide);
            }
        }
        
        private void InitStates()
        {
            _SM = new StateMachine();

            _hide = new Player_Hide(_playerComponents);
            _move = new Player_Move(_playerComponents);
        }

        private void InitComponents()
        {
            _playerComponents = GetComponent<PlayerComponents>();
        }
    }