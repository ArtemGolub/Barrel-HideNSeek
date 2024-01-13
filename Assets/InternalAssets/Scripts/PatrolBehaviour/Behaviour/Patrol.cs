
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : IPatrolBehaviour
{
    private List<Transform> _patrolPoints;
    private NavMeshAgent _agent;
    private float offSet = 0.2f;
    private int _pointIndex;
    
    public void Enter(EnemyComponents enemyComponents)
    {
        _agent = enemyComponents.Agent;
        _patrolPoints = enemyComponents.PatrolPoints;
        _agent.isStopped = false;
    }

    public void Exit(EnemyComponents enemyComponents)
    {
        _agent.isStopped = true;
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

// TODO Enemy Animations

// TODO Pop-up Win
// TODO Pop-up Lose
// TODO Restart Button

// TODO Level Design

// TODO PlayerDeath BUGfix

// TODO ReadMe

//TODO OPTIONAL
// TODO Timer
// TODO Score
