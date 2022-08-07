using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartOfGame : MonoBehaviour
{
    public UnityEvent WhenGameStarts;

    void Start()
    {
        if (WhenGameStarts.GetPersistentEventCount() > 0) WhenGameStarts.Invoke();
    }

    
}
