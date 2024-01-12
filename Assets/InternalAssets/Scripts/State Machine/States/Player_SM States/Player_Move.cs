using StateManager;
using UnityEditor.Animations;
using UnityEngine;

public class Player_Move: State
{
    private PlayerComponents _playerComponents;
    
    private PlayerAnimationControll _animationControll;
    private Rigidbody _rigidbody;
    public FixedJoystick _joystick;
    
    private float _moveSpeed;

    public Player_Move(PlayerComponents components)
    {
        _playerComponents = components;
        SetupComponents();
        SetupSettings();
    }
    
    public override void Enter()
    {
        _animationControll.MoveAnimation(true);
    }

    public override void Exit()
    {
        _animationControll.MoveAnimation(true);
    }

    public override void Update()
    {
        CharacterMovement();
        CharacterRotation();
    }
    private void SetupComponents()
    {
        _animationControll = _playerComponents.AnimationControll;
        _rigidbody = _playerComponents.Rigidbody;
        _joystick = _playerComponents.Joystick;
    }

    private void SetupSettings()
    {
        _moveSpeed = _playerComponents.Settings.MoveSpeed;
    }
    
    private void CharacterMovement()
    {
        Vector3 direction = new Vector3(_joystick.Horizontal, _rigidbody.velocity.y, _joystick.Vertical);
        _rigidbody.velocity = direction * _moveSpeed;
    }

    private void CharacterRotation()
    {
        _playerComponents.PlayerTransform.transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
    }
    
    

}