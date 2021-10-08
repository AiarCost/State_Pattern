using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IPlayerState
{

    Rigidbody rbPlayer;
    float Counter;

    public void Enter(Player player)
    {
        Debug.Log("Entering: Jumping");
        player.mCurrentState = this;

        //add force to the player's rb
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.velocity = new Vector3(0, 10, 0);
        Counter = Time.time;

    }

    public void Execute(Player playerState)
    {
        //if it is near floor & has been launched for a bit...
        if(rbPlayer.transform.position.y <-1.5f && (Time.time - Counter) > .5f)
        {
            //Standing
            StandingState standing = new StandingState();
            standing.Enter(playerState);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //Diving
            DivingState diving = new DivingState();
            diving.Enter(playerState);
        }


    }
}
