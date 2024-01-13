
using System;
using UnityEngine;
using StateManager;

    public class Enemy_SM: MonoBehaviour
    {
        private StateMachine _SM;
        private EnemyComponents _components;
        
        private Enemy_Patrol _enemyPatrol;
        private Enemy_Catch _enemyCatch;

        private void InitStates()
        {
            _SM = new StateMachine();

            _enemyPatrol = new Enemy_Patrol(_components);
            _enemyCatch = new Enemy_Catch();
        }

        private void InitComponents()
        {
            _components = GetComponent<EnemyComponents>();
        }

        private void Start()
        {
            _SM.Initialize(_enemyPatrol);
        }

        private void Awake()
        {
            InitComponents();
            InitStates();
        }

        private void Update()
        {
            _SM.CurrentState.Update();
        }
    }