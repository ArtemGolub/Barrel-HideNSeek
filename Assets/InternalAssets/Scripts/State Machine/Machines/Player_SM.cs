using UnityEngine;
using StateManager;
[RequireComponent(typeof(PlayerComponents), typeof(Rigidbody), typeof(CapsuleCollider))]
    public class Player_SM: MonoBehaviour
    {
        private PlayerComponents _playerComponents;
        private StateMachine _SM;
        private Player_Hide _hide;
        private Player_Move _move;
        private Player_Gotcha _gotcha;
        
        public bool isMoving()
        {
            return _playerComponents.Joystick.Horizontal != 0 || _playerComponents.Joystick.Vertical != 0;
        }

        public bool isHidden()
        {
            if (_SM.CurrentState == _hide) return true;
            return false;
        }

        private bool isMovementDisabled()
        {
            if (_SM.CurrentState == _gotcha) return true;
            return false;
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
            if(isMovementDisabled()) return;
            if (!isMoving())
            {
                _SM.ChangeState(_hide);
                return;
            }
            else
            {
                _SM.ChangeState(_move);
            }
           
            _SM.CurrentState.Update();
        }
        
        private void InitStates()
        {
            _SM = new StateMachine();

            _hide = new Player_Hide(_playerComponents);
            _move = new Player_Move(_playerComponents);
            _gotcha = new Player_Gotcha(_playerComponents);
        }

        private void InitComponents()
        {
            _playerComponents = GetComponent<PlayerComponents>();
        }

        public void Gotcha(Transform target)
        {
            _gotcha.UpdateTarget(target);
            _SM.ChangeState(_gotcha);
        }
    }