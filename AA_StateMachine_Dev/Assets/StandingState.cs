using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : IPlayerState
{
    public void Enter(Player player)
    {
        Debug.Log("Entering: Stand State");
        player.mCurrentState = this;
    }


    public void Execute(Player playerState)
    {
        //Since there is nothing that occurs when standing...no code here just transitions

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Jumping
            JumpingState jumping = new JumpingState();
            jumping.Enter(playerState);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //Ducking
            DuckingState ducking = new DuckingState();
            ducking.Enter(playerState);
        }
    }
}
