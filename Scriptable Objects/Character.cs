using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{   
    WALK,
    RUN,
    TACKLE,
    STUN,
    INTERACT,
    ABILITY
}

public class Character : ScriptableObject
{
    //Character data
    public string name;
    public Sprite icon;

    //Mechanical stats
    public float moveSpeed;
    public VectorValue startingPosition;
    public PlayerState currentState;

    //Abstract functions for using abilities
    public abstract void AbilityA();
    public abstract void AbilityB();
    public abstract void AbilityC();
}
