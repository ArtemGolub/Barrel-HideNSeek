using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationControll : MonoBehaviour
{
    private PlayerComponents _playerComponents;
    private void Start()
    {
        _playerComponents = GetComponent<PlayerComponents>();
    }
    
    public void MoveAnimation(bool isMove)
    {
        _playerComponents.Animator.SetBool("isMove", isMove);
    }

    public void GotchaAnim(bool isGotcha)
    {
        _playerComponents.Animator.SetBool("isGotcha", isGotcha);
    }
}
