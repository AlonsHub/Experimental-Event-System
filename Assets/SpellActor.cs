using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellActor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoAction();
        }
    }

    void DoAction()
    {
        Spell_GED ged = new Spell_GED(name, "Pawn A", "fireball", "2");
        GameEventManager.TriggerTypedEvent("somethingHappened", ged);
    }
}
