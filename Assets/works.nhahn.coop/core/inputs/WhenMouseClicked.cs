using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WhenMouseClicked : MonoBehaviour
{
    public UnityEvent whenLeftMouseClicked;
    public UnityEvent whileLeftMouseHeldDown;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (whenLeftMouseClicked.GetPersistentEventCount() > 0) whenLeftMouseClicked.Invoke();
        }
        if (Input.GetMouseButton(0))
        {
            if (whileLeftMouseHeldDown.GetPersistentEventCount() > 0) whileLeftMouseHeldDown.Invoke();
        }
    }
}
