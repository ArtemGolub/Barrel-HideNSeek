using UnityEngine;
[RequireComponent(typeof(Rigidbody), typeof(PlayerAnimationControll))]
public class PlayerComponents : MonoBehaviour
{
    [Header("Player Settings")]
    public PlayerSettings Settings;
    public Transform PlayerTransform;
    public Rigidbody Rigidbody;
    public FixedJoystick Joystick;
    public PlayerAnimationControll AnimationControll;
    public Animator Animator;
    public Player_SM PlayerSm;

    [Header("Barrel Settings")] 
    public Transform Barrel;
    public Transform BarrelHandler;

    private void Awake()
    {
        InitComponents();
    }
    private void InitComponents()
    {
        Rigidbody = GetComponent<Rigidbody>();
        AnimationControll = GetComponent<PlayerAnimationControll>();
        Animator = GetComponent<Animator>();
        PlayerSm = GetComponent<Player_SM>();
    }
}
