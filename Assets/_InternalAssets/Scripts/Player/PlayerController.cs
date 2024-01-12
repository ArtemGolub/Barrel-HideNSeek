using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Rigidbody _rigidbody;
    private FixedJoystick _joystick;
    
    #region UnityMethods

    private void Start()
    {
        InitMovement();
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
        _joystick = FixedJoystick.current;
    }
    private void CharacterMovement()
    {
        Vector3 direction = new Vector3(_joystick.Horizontal, _rigidbody.velocity.y, _joystick.Vertical);
        _rigidbody.velocity = direction * _moveSpeed;
    }

    private void CharacterRotation()
    {
        if (_joystick.Horizontal == 0 || _joystick.Vertical == 0) return;
        transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
    }
}
