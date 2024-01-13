using UnityEngine;
[RequireComponent(typeof(Rigidbody), typeof(PlayerAnimationControll))]
public class PlayerComponents : MonoBehaviour
{
    [Header("Settings")]
    public PlayerSettings Settings;
    
    [Header("Scripts")]
    public FixedJoystick Joystick;
    public PlayerAnimationControll AnimationControll;
    public Player_SM PlayerSm;
    public BarrelController BarrelController;
    
    [Header("Components")]
    public Transform PlayerTransform;
    public Rigidbody Rigidbody;
    public Animator Animator;
   

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
        BarrelController = GetComponent<BarrelController>();
    }
}
