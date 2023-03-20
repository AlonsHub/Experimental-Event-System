using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventManager : MonoBehaviour
{
    public static GameEventManager Instance;

    public Dictionary<string, UnityEvent> events;
    public Dictionary<string, GameEvent> typedEvents;

    private void Awake()
    {
        if(Instance !=null && Instance !=this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        events = new Dictionary<string, UnityEvent>();
        typedEvents = new Dictionary<string, GameEvent>();
    }

    public static void AddListener(string eventName, UnityAction action)
    {
        UnityEvent e = null;
        if(Instance.events.TryGetValue(eventName, out e))
        {
            e.AddListener(action);
        }
        else
        {
            e = new UnityEvent();
            e.AddListener(action);
            Instance.events.Add(eventName, e);
        }    
    }
    public static void AddTypedListener(string eventName, UnityAction<GameEventData> action)
    {
        GameEvent e = null;
        if(Instance.typedEvents.TryGetValue(eventName, out e))
        {
            e.AddListener(action);
        }
        else
        {
            e = new GameEvent();
            e.AddListener(action);
            Instance.typedEvents.Add(eventName, e);
        }    
    }

    public static void RemoveListener(string eventName, UnityAction action)
    {
        UnityEvent e = null;
        if(Instance.events.TryGetValue(eventName, out e))
        {
            e.RemoveListener(action);
        } 
    }
    public static void RemoveTypedListener(string eventName, UnityAction<GameEventData> action)
    {
        GameEvent e = null;
        if(Instance.typedEvents.TryGetValue(eventName, out e))
        {
            e.RemoveListener(action);
        } 
    }

    public static void TriggerEvent(string eventName)
    {
        UnityEvent e = null;
        if(Instance.events.TryGetValue(eventName, out e))
        {
            e.Invoke(); //Does this need a ?
        } 
    }
    public static void TriggerTypedEvent(string eventName, GameEventData ged)
    {
        GameEvent e = null;
        if(Instance.typedEvents.TryGetValue(eventName, out e))
        {
            e.Invoke(ged); //Does this need a ?
        } 
    }


}
