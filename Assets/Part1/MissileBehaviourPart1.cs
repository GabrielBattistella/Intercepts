using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBehaviourPart1 : MonoBehaviour
{

    Vector3 positionTarget = new Vector3(45, 30, 400);

    float speedRate = 5f;


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, positionTarget, speedRate * Time.deltaTime);
    }
}
