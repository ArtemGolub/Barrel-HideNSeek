using UnityEngine;
[CreateAssetMenu(fileName = "New Enemy Settings", menuName = "Custom/New Enemy Settings")]
public class EnemySettings : ScriptableObject
{
    public EnemyType enemyType;
    public float moveSpeed;
}
