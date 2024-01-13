using StateManager;
using UnityEngine;

public class Player_Gotcha: State
{
    private PlayerComponents _components;
    private Transform lookTarget;
    
    public Player_Gotcha(PlayerComponents components)
    {
        _components = components;
    }
    
    public override void Enter()
    {
        _components.BarrelController.RemoveBarrel();
        _components.AnimationControll.GotchaAnim(true);
        _components.PlayerTransform.LookAt(lookTarget);
        _components.Rigidbody.velocity = new Vector3(0, 0, 0);
        EventManager.current.Lose.Invoke();
    }
    

    public override void Exit()
    {
        _components.AnimationControll.GotchaAnim(false);
    }

    public void UpdateTarget(Transform target)
    {
        lookTarget = target;
    }
}