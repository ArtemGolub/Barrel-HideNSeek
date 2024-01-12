using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BarrelAnimationControll : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    public void IsMove(bool isMove)
    {
        _animator.SetBool("isMove", isMove);
    }
    
}
