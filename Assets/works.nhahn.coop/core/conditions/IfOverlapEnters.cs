using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IfOverlapEnters : MonoBehaviour
{
    public UnityEvent WhenOverlapStarts;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (WhenOverlapStarts.GetPersistentEventCount() > 0) WhenOverlapStarts.Invoke();
    }
}
