using UnityEngine;

public class Stationary : IPatrolBehaviour
{
    public void Enter(EnemyComponents enemyComponents)
    {
        enemyComponents.AnimationControll.IsMove(false);
    }

    public void Exit(EnemyComponents enemyComponents)
    {
        throw new System.NotImplementedException();
    }

    public void Update(EnemyComponents enemyComponents)
    {
        
    }
}