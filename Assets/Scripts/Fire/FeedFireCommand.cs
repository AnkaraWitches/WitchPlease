using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedFireCommand : ICommand
{
    private Fire fire;
    private string methodName;
    private Fire.FireState previousFireState;

    public FeedFireCommand(Fire fire, string methodName)
    {
        this.fire = fire;
        this.methodName = methodName;
    }

    //methods
    public void Execute()
    {
        Debug.Log("Execute of FeedFireCommand");
        previousFireState = fire.GetFireState();
        fire.FeedFire();
    }

    public void Undo()
    {
        if (previousFireState == Fire.FireState.Big) fire.Extinguish();
        else if (previousFireState == Fire.FireState.BigF) fire.FeedFire();
        else if (previousFireState == Fire.FireState.UnlitF) fire.FeedFire();
    }

    public void Redo()
    {
        Execute();
    }
}