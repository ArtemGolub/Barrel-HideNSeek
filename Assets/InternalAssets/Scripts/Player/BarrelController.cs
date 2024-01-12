using UnityEngine;

public class BarrelController : MonoBehaviour
{
    private PlayerComponents _playerComponents;
    
    [HideInInspector] public BarrelAnimationControll _animator;
    private Transform _barrel;
    private void Start()
    {
        _playerComponents = GetComponent<PlayerComponents>();
        _barrel = _playerComponents.Barrel;
        _animator = _barrel.GetComponent<BarrelAnimationControll>();

        GetBarrel(_playerComponents.BarrelHandler);
    }
    public void GetBarrel(Transform barrelHolder)
    {
        if(_playerComponents.Barrel == null) return;
        
        var barrel = _playerComponents.Barrel;
        barrel.SetParent(barrelHolder);
        barrel.position = barrelHolder.position;
    }

    public void RemoveBarrel()
    {
        if(_playerComponents.Barrel == null) return;
        
        var barrel = _playerComponents.Barrel;
        barrel.transform.SetParent(null);
    }
}
