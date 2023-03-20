using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BattleLog : MonoBehaviour
{

    UnityAction<GameEventData> gameEvent;
    // Start is called before the first frame update
    void Start()
    {
        gameEvent += (x) => print(x);
        //gameEvent+= ((x) => print(x));
        //gameEvent += print;
        GameEventManager.AddTypedListener("somethingHappened", gameEvent);   
    }

    void print(GameEventData ged)
    {
        if (ged is Action_GED)
        {
            Action_GED newGed = (Action_GED)ged;
            Debug.Log($"{newGed.activePawn} used {newGed.actionItem} on {newGed.primaryTarget}");
        }
        else if(ged is Spell_GED)
        {
            Spell_GED newGed = (Spell_GED)ged;
            Debug.Log($"{newGed.activePawn} used {newGed.spell} spell on {newGed.primaryTarget}");
        }
    }

}
