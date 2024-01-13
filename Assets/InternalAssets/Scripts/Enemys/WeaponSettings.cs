using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon Settings", menuName = "Custom/New Weapon Settings")]
public class WeaponSettings: ScriptableObject
{
    public WeaponType weaponType;
    
    [Header("Sniper")]
    public float AttackRange;

    [Header("Pistol")] 
    public float Radius;
    [Range(0,360)]
    public float Angle;
    
    public LayerMask targetMask;
    public LayerMask obstructionMask;
}