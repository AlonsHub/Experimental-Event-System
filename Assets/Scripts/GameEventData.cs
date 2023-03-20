using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventData 
{
    //perhaps a basic constructor for all to inherit?
    public GameEventData()
    {

    }

    //public BattlelogVariant GetDataForLog()
}
/// <summary>
/// Action GameEventData 
/// </summary>
public class Action_GED : GameEventData
{
    public string activePawn;
    public string primaryTarget;
    public string secondaryTarget;
    public string actionItem;
    public string numberValue;

    public Action_GED(string aPawn, string pTarget, string sTarget, string aItem, string nValue) : base()
    {
        activePawn = aPawn;
        primaryTarget = pTarget;
        secondaryTarget = sTarget;
        actionItem = aItem;
        numberValue = nValue;
    }

}
public class Spell_GED : GameEventData
{
    public string activePawn;
    public string primaryTarget;
    public string spell;
    public string numberValue;

    public Spell_GED(string aPawn, string pTarget, string s, string nValue) : base()
    {
        activePawn = aPawn;
        primaryTarget = pTarget;

        spell = s;
        numberValue = nValue;
    }
}
//Not sure about movement
public class Movement_GED : GameEventData
{

}
