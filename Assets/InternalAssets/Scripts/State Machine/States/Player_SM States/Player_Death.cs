using StateManager;
using UnityEngine;

public class Player_Death: State
{
    public override void Enter()
    {
        Debug.Log("Death");
       
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }
}