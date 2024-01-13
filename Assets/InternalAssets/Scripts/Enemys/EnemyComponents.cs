using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(Enemy_SM), typeof(EnemyAnimationControll), typeof(Weapon))]
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
    public NavMeshAgent Agent;

    [Header("Patroll")] 
    public List<Transform> PatrolPoints;

}
