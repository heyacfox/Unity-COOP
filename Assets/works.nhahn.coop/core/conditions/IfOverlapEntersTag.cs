using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IfOverlapEntersTag : MonoBehaviour
{
    public new string tag = "";
    public UnityEvent<GameObject> WhenEntersOverlap;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(this.tag))
        {
            if (WhenEntersOverlap.GetPersistentEventCount() > 0) WhenEntersOverlap.Invoke(collision.gameObject);
        }
    }
}
