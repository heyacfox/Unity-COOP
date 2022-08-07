using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EveryFrame : MonoBehaviour
{
    public UnityEvent OnEveryFrame;
    
    void Update()
    {
        if (OnEveryFrame.GetPersistentEventCount() > 0) OnEveryFrame.Invoke();   
    }
}
