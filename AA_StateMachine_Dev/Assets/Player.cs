using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public IPlayerState mCurrentState;

    // Start is called before the first frame update
    void Awake()
    {   //Starts the player off in the standing state
        mCurrentState = new StandingState();
    }

    // Update is called once per frame
    void Update()

    {   //This will constantly call what state it is in and do the function that is related to it
        mCurrentState.Execute(this);
    }
}
