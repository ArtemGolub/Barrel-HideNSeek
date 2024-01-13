using UnityEngine;

public class Pistol : IWeaponBehaviour
{
    private Weapon _weapon;
    private float radius;
    private float angle;
    private LayerMask targetMask;
    private LayerMask obstacleMask;
    private bool canSeePlayer;
    public Pistol(Weapon weapon)
    {
        _weapon = weapon;
        radius = _weapon.Settings.Radius;
        angle = _weapon.Settings.Angle;
        targetMask = _weapon.Settings.targetMask;
        obstacleMask = _weapon.Settings.obstructionMask;
    }
    public void UpdateTarget()
    {
        FieldOfViewCheck();
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(_weapon.transform.position, radius, targetMask);

        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - _weapon.transform.position).normalized;

            if (Vector3.Angle(_weapon.transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(_weapon.transform.position, target.position);

                if (!Physics.Raycast(_weapon.transform.position, directionToTarget, distanceToTarget, obstacleMask))
                {
                    var playerCheck = target.GetComponent<Player_SM>();
                    if (playerCheck.isHidden()) return;
                    _weapon.Target = target;
                    canSeePlayer = true;
                    _weapon.GetComponent<Enemy_SM>(). EnemyCatch();
                    playerCheck.Gotcha(_weapon.transform);
                    Shoot();
                }
                else
                
                    canSeePlayer = false;
            }
            else
                canSeePlayer = false;
        }
        else if (canSeePlayer)
            canSeePlayer = false;
    }
    
    private void Shoot()
    {
        var bulletGo = _weapon.InstantiateBullet();
        IBullet bullet = bulletGo.GetComponent<IBullet>();
        if (bullet != null)
        {
            bullet.Seek(_weapon.Target);
        }
    }
}
