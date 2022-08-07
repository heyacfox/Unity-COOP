using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchObjectTowardsMouse : MonoBehaviour
{
    public Transform launchPosition;
    public float launchForce = 1;

    private float defaultMultiplier = 100;


    private void Start()
    {
        if (launchPosition == null)
        {
            launchPosition = this.transform;
        }
    }

    public void launchObject(GameObject gameObject)
    {
        GameObject instantiatedObject = Instantiate(gameObject, launchPosition.position, gameObject.transform.rotation);

        Rigidbody2D instantiatedRigidbody = instantiatedObject.GetComponent<Rigidbody2D>();
        if (instantiatedRigidbody == null)
        {
            instantiatedRigidbody = instantiatedObject.AddComponent<Rigidbody2D>();
        }
        instantiatedRigidbody.gravityScale = 0;
        Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mouseWorldDirection = mouseWorldPosition.normalized;

        instantiatedRigidbody.AddForce(launchForce * defaultMultiplier * mouseWorldDirection);
    }



}
