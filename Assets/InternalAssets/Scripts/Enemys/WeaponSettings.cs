using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon Settings", menuName = "Custom/New Weapon Settings")]
public class WeaponSettings: ScriptableObject
{
    public WeaponType weaponType;
    public float AttackRange;
}