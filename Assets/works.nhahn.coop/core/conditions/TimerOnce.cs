using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerOnce : MonoBehaviour
{
    public UnityEvent whenTimerFinished;

    public void StartTimerForSeconds(float seconds)
    {
        Invoke("resolveTimer", seconds);
    }

    private void resolveTimer()
    {
        if (whenTimerFinished.GetPersistentEventCount() > 0) whenTimerFinished.Invoke();
    }

    public void CancelTimer()
    {
        CancelInvoke();
    }


}
