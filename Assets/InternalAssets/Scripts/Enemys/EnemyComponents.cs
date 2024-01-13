using UnityEngine;

public class EnemyComponents : MonoBehaviour
{
    [Header("Settings")]
    public EnemySettings settings;
    
    [Header("Scripts")]
    public EnemyAnimationControll AnimationControll;
    public Weapon weapon;
    public Enemy_SM EnemySm;
    
    [Header("Components")]
    public Animator Animator;
    public Transform EnemyTransform;
  
}
