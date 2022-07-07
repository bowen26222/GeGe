using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Data", menuName = "Character Stats/Data")]

public class CharacterData : ScriptableObject
{
    [Header("Stats Info")]
    public float maxEndurance;
    public float currentEndurance;
    public float consumeSpeed;
    public float recoverSpeed;

    public bool isOccupied;
    public bool FlyAble = true;
    
    public bool LeftWing = false;
    public bool RightWing = false;
}
