using UnityEngine;

public static class BehaviourFabric
{
    public static IPatrolBehaviour CreatePatrolBehaviour(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Stationary:
            {
                return new Stationary();
            }
            case EnemyType.Patrol:
            {
                return new Patrol();
            }
            default:
            {
                Debug.LogError("No implemented Patrol Behaviour for: " + enemyType + " enemy type");
                break;
            }
        }

        return null;
    }

    public static IWeaponBehaviour CreateWeaponBehaviour(WeaponType weaponType, Weapon weapon)
    {
        switch (weaponType)
        {
            case WeaponType.Pistol:
            {
                return new Pistol(weapon);
            }
            case WeaponType.Sniper:
            {
                return new Sniper(weapon);
            }
            default:
            {
                Debug.LogError("No implemented Weapon Behaviour for: " + weaponType + " weapon type");
                break;
            }
        }

        return null;
    }
}
