using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMovement : MonoBehaviour
{
    public List<Transform> pathPositions;
    public float moveSpeed = 3;

    private int patrolIndex = 0;
    private float minDistance = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPosition = pathPositions[patrolIndex].position;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * moveSpeed);
        if (Vector2.Distance(transform.position, targetPosition) < minDistance)
        {
            patrolIndex++;
            if (patrolIndex >= pathPositions.Count)
            {
                patrolIndex = 0;
            }
        }

    }

}
