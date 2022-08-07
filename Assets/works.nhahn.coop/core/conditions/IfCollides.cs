using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IfCollides : MonoBehaviour
{
    public UnityEvent<GameObject> WhenObjectCollides;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (WhenObjectCollides.GetPersistentEventCount() > 0) WhenObjectCollides.Invoke(collision.gameObject);
    }
}
