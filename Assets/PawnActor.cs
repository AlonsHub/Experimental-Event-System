using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnActor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DoAction();
        }
    }

    void DoAction()
    {
        Action_GED ged = new Action_GED(name, "something", "", "stick", "2");
        GameEventManager.TriggerTypedEvent("somethingHappened", ged);
    }
}
