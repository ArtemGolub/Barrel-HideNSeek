using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BarrelAnimationControll : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    
    public void IsMove(bool isMove)
    {
        _animator.SetBool("isMove", isMove);
    }

    public void IsRemove(bool isRemove)
    {
        _animator.SetBool("isRemove", isRemove);
    }
}
