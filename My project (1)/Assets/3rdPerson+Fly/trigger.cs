using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoveUp : MonoBehaviour
{
    public float moveSpeed = 20f;      
    public float moveDistance = 123f;   

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool shouldMove = false;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + new Vector3(0, moveDistance, 0);
    }

    void Update()
    {
        if (shouldMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (transform.position == targetPosition)
            {
                shouldMove = false;
            }
        }
    }

    public void OpenDoor()
    {
        shouldMove = true;
    }
}

