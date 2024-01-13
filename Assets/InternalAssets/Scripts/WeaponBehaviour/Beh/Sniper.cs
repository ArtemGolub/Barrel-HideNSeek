using UnityEngine;

public class Sniper : IWeaponBehaviour
{
    private Weapon _weapon;
    private float AttackRange;

    public Sniper(Weapon weapon)
    {
        _weapon = weapon;
        AttackRange = _weapon.Settings.AttackRange;
    }
    
    public void Shoot()
    {
        var bulletGo = _weapon.InstantiateBullet();
        IBullet bullet = bulletGo.GetComponent<IBullet>();
        if (bullet != null)
        {
            bullet.Seek(_weapon.Target);
        }
    }

    public void UpdateTarget()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        
        float shortestDistance = Mathf.Infinity;
        
        Transform nearestPlayer = null;
        
        float distanceToEnemy = Vector3.Distance(_weapon.transform.position, player.position);
        if (distanceToEnemy < shortestDistance)
        {
            shortestDistance = distanceToEnemy;
            nearestPlayer = player;
        }
        if (nearestPlayer != null && shortestDistance <= AttackRange)
        {
            var playerCheck = player.GetComponent<Player_SM>();
            if (playerCheck.isHidden()) return;
            _weapon.Target = nearestPlayer;
            _weapon.GetComponent<Enemy_SM>(). EnemyCatch();
            playerCheck.Gotcha(_weapon.transform);
            //Shoot();
        }
    }
}
