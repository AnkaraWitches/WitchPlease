using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageCommand: ICommand{
private Cage cage;
    private string name;

    public CageCommand(Cage cage, string name)
    {
        this.cage = cage;
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void Execute()
    {
        Debug.Log("Candles are fired");
        if (cage.transform.localPosition.x != -0.56f){
            cage.OpenCage();
        }
        else{
            cage.CloseCage();
        }
    }

    public void Undo()
    {
        if (cage.transform.localPosition.x == -0.56f){
            cage.CloseCage();
        }
        else{
            cage.OpenCage();
        }
    }

    public void Redo(){
       Debug.Log("Candles are redoned");
        if (cage.transform.localPosition.x != -0.56f){
            cage.OpenCage();
        }
        else{
            cage.CloseCage();
        }
    }

}