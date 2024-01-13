using StateManager;

public class Enemy_Catch: State
{
    private EnemyComponents _components;
    public Enemy_Catch(EnemyComponents components)
    {
        _components = components;
    }
    
    public override void Enter()
    {
        _components.EnemyTransform.transform.LookAt(_components.weapon.Target);
        _components.AnimationControll.IsCatch(true);
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        
    }
}