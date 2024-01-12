using UnityEngine;

public class BarrelController : MonoBehaviour
{
    [HideInInspector]public BarrelAnimationControll _animator;

    private void Start()
    {
        _animator = GetComponent<BarrelAnimationControll>();
    }

    public void GetBarrel(Transform barrelHolder)
    {
        transform.SetParent(barrelHolder);
        transform.position = barrelHolder.position;
    }

    public void RemoveBarrel()
    {
        transform.SetParent(null);
    }
}
