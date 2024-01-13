
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : IPatrolBehaviour
{
    private EnemyComponents _components;
    private List<Transform> _patrolPoints;
    private NavMeshAgent _agent;
    private float offSet = 0.2f;
    private int _pointIndex;
    
    public void Enter(EnemyComponents enemyComponents)
    {
        _components = enemyComponents;
        _agent = _components.Agent;
        _patrolPoints = _components.PatrolPoints;
        _agent.isStopped = false;
        _components.AnimationControll.IsMove(true);
    }

    public void Exit(EnemyComponents enemyComponents)
    {
        _agent.isStopped = true;
        _components.AnimationControll.IsMove(false);
    }

    public void Update(EnemyComponents enemyComponents)
    {
        UpdatePoints();
    }

    private void UpdatePoints()
    {
        if (_agent.remainingDistance <= offSet)
        {
            _pointIndex++;
            if (_pointIndex >= _patrolPoints.Count)
            {
                _pointIndex = 0;
            }
            _agent.destination = _patrolPoints[_pointIndex].transform.position;
        }
    }
    
    
}


// TODO Level Design

// TODO PlayerDeath BUGfix

// TODO ReadMe

//TODO OPTIONAL
// TODO Timer
// TODO Score
