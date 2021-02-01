using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterceptorBehaviourPart1 : MonoBehaviour
{
    public GameObject missileGameObjecto;

    float speedRate = 10;


    void Update()
    {
        if(missileGameObjecto != null)
            transform.position = Vector3.MoveTowards(transform.position, missileGameObjecto.transform.position, speedRate * Time.deltaTime);
    }


    private void LateUpdate()
    {
        if (missileGameObjecto != null)
            transform.LookAt(missileGameObjecto.transform.position);
    }


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
