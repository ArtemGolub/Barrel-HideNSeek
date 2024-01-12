using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationControll : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    public void MoveAnimation(bool isMove)
    {
        _animator.SetBool("isMove", isMove);
    }
}
