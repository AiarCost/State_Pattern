using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingState : IPlayerState
{
    public GameObject Player;

    public void Enter(Player player)
    {
        Debug.Log("Entering: Ducking");

        player.mCurrentState = this;
        Player = player.gameObject;
        //Shrink the object
        Player.transform.localScale = new Vector3(.5f, .5f, .5f);
    }

    public void Execute(Player playerState)
    {

        if (!Input.GetKey(KeyCode.S))
        {
            //standing
            Player.transform.localScale = new Vector3(1f, 1f, 1f);
            StandingState standing = new StandingState();
            standing.Enter(playerState);
        }
    }
}
