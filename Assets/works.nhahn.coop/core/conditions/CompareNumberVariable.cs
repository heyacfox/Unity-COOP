using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CompareNumberVariable : MonoBehaviour
{
    public NumberVariable numberVariable;
    public UnityEvent IfCheckTrue;

    public void IfNumberEqual(float check)
    {
        if (numberVariable.number == check)
        {
            if (IfCheckTrue.GetPersistentEventCount() > 0) IfCheckTrue.Invoke();
        }
    }

    public void IfNumberLess(float check)
    {
        if (numberVariable.number < check)
        {
            if (IfCheckTrue.GetPersistentEventCount() > 0) IfCheckTrue.Invoke();
        }
    }

    public void IfNumberGreater(float check)
    {
        if (numberVariable.number > check)
        {
            if (IfCheckTrue.GetPersistentEventCount() > 0) IfCheckTrue.Invoke();
        }
    }
}
