using System;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [Header("Weapon Settings")]
    public WeaponSettings Settings;
    [HideInInspector] public Transform Target;
    public Transform rangeRadius;
    
    [Header("Bullet Settings")]
    [SerializeField]private GameObject prBullet;
    [SerializeField]private Transform bulletInitPlace;
    
    private IWeaponBehaviour _weaponBehaviour;
    public GameObject InstantiateBullet()
    {
        return Instantiate(prBullet, bulletInitPlace);
    }
    private void Start()
    {
        _weaponBehaviour = BehaviourFabric.CreateWeaponBehaviour(Settings.weaponType, this);
        SetupRangeRadius();
        InvokeRepeating("StartUpdatingTarget", 0,0.5f);
    }
    
    private void StartUpdatingTarget()
    {
        if (Target != null)
        {
            CancelInvoke("StartUpdatingTarget");
            return;
        }
        _weaponBehaviour.UpdateTarget();
    }

    private void SetupRangeRadius()
    {
        if (Settings.weaponType == WeaponType.Sniper)
        {
            rangeRadius.transform.localScale = new Vector3(Settings.AttackRange, 1, Settings.AttackRange);
        }
        else
        {
            rangeRadius.transform.localScale = new Vector3(Settings.AttackRange - 1, 1, Settings.AttackRange - 1);
            rangeRadius.localPosition += new Vector3(0, 0, 1);
        }
       
    }
    // private void OnDrawGizmos()
    // {
    //     Gizmos.color = Color.green;
    //     Gizmos.DrawSphere(transform.position, Settings.AttackRange);
    // }
}



