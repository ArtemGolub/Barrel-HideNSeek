using StateManager;
using UnityEngine;

public class Enemy_Catch: State
{
    private EnemyComponents _components;
    public Enemy_Catch(EnemyComponents components)
    {
        _components = components;
    }
    
    public override void Enter()
    {
        _components.AnimationControll.IsCatch(true);
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        _components.EnemyTransform.transform.LookAt(_components.weapon.Target);
    }
}