using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingState : IPlayerState
{
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering: Diving");
        player.mCurrentState = this;

        //add force to the player's rb
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.velocity = new Vector3(0, -20, 0);
    }

    public void Execute(Player playerState)
    {
        if (Physics.Raycast(rbPlayer.transform.position, Vector3.down, 0.55f))
        {
            //Standing
            StandingState standing = new StandingState();
            standing.Enter(playerState);
        }
    }
}
