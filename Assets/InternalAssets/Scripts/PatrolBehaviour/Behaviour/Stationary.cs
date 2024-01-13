using UnityEngine;

public class Stationary : IPatrolBehaviour
{
    public void Enter(EnemyComponents enemyComponents)
    {
        enemyComponents.Agent.enabled = false;
        enemyComponents.AnimationControll.IsMove(false);
    }

    public void Exit(EnemyComponents enemyComponents)
    {
        enemyComponents.Agent.enabled = true;
    }

    public void Update(EnemyComponents enemyComponents)
    {
        
    }
}