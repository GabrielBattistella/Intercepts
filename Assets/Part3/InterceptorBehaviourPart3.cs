using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterceptorBehaviourPart3 : MonoBehaviour
{
    public List<GameObject> missileGameObjects;

    public GameObject currentMissileTarget;

    float speedRate = 10;


    private void Start()
    {
        currentMissileTarget = GetMostCloseMissile();
    }

    void Update()
    {
        if (currentMissileTarget != null)
            transform.position = Vector3.MoveTowards(transform.position, currentMissileTarget.transform.position, speedRate * Time.deltaTime);
    }


    private void LateUpdate()
    {
        if (currentMissileTarget != null)
            transform.LookAt(currentMissileTarget.transform.position);
    }


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        missileGameObjects.Remove(other.gameObject);
        currentMissileTarget = GetMostCloseMissile();
    }



    GameObject GetMostCloseMissile()
    {
        GameObject mostCloseObj = null;
        float minDist = Mathf.Infinity;
        foreach (var missile in missileGameObjects)
        {
            float dist = Vector3.Distance(missile.transform.position, transform.position);
            if(dist < minDist)
            {
                minDist = dist;
                mostCloseObj = missile;
            }

        }

        return mostCloseObj;

    }

}
