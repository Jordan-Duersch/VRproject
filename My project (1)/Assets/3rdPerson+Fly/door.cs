using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMoveBlock : MonoBehaviour
{
    public GameObject blockToMove;
    public Vector3 moveDirection;  

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            blockToMove.transform.position += moveDirection;
        }
    }
}
