using StateManager;

public class Enemy_Patrol: State
{
    private EnemyComponents _components;
    private IPatrolBehaviour _patrolBehaviour;

    public Enemy_Patrol(EnemyComponents components)
    {
        _components = components;
        _patrolBehaviour = BehaviourFabric.CreatePatrolBehaviour(_components.settings.enemyType);
    }
    
    public override void Enter()
    {
        _patrolBehaviour.Enter(_components);
    }

    public override void Exit()
    {
        _patrolBehaviour.Exit(_components);
    }

    public override void Update()
    {
        _patrolBehaviour.Update(_components);
    }
}