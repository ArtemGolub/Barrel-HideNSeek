using UnityEngine;
[RequireComponent(typeof(Rigidbody), typeof(PlayerAnimationControll))]
public class PlayerComponents : MonoBehaviour
{
    public PlayerSettings Settings;
    public Transform PlayerTransform;
    public Rigidbody Rigidbody;
    public FixedJoystick Joystick;
    public PlayerAnimationControll AnimationControll;
    public Animator Animator;

    private void Awake()
    {
        InitComponents();
    }
    private void InitComponents()
    {
        Rigidbody = GetComponent<Rigidbody>();
        AnimationControll = GetComponent<PlayerAnimationControll>();
        Animator = GetComponent<Animator>();
    }
}
