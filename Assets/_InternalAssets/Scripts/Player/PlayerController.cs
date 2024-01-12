using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider), typeof(PlayerAnimationControll))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Setup")]
    [SerializeField] private float _moveSpeed;
    private Rigidbody _rigidbody;
    private FixedJoystick _joystick;
    private PlayerAnimationControll _animationControll;
    [Header("Barrel Setup")]
    [SerializeField]private BarrelController _barrelController;
    [SerializeField] private Transform _holder;
    
    #region UnityMethods

    private void Start()
    {
        InitMovement();
    }

    private void Update()
    {
        GetBarrel();
        RemoveBarrel();
    }

    private void FixedUpdate()
    {
        CharacterMovement();
        CharacterRotation();
    }

    #endregion
    
    private void InitMovement()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animationControll = GetComponent<PlayerAnimationControll>();
        _joystick = FixedJoystick.current;
        
    }
    private void CharacterMovement()
    {
        Vector3 direction = new Vector3(_joystick.Horizontal, _rigidbody.velocity.y, _joystick.Vertical);
        _rigidbody.velocity = direction * _moveSpeed;
    }

    private void CharacterRotation()
    {
        if (_joystick.Horizontal == 0 || _joystick.Vertical == 0)
        {
            _animationControll.MoveAnimation(false);
            _barrelController._animator.IsMove(false);
            return;
        }
        _animationControll.MoveAnimation(true);
        _barrelController._animator.IsMove(true);
        transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        
    }

    private void GetBarrel()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _barrelController.GetBarrel(_holder);
        }
    }

    private void RemoveBarrel()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _barrelController.RemoveBarrel();
        }
    }
}
