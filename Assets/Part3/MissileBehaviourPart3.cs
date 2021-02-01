using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBehaviourPart3 : MonoBehaviour
{

    Vector3 positionTarget = new Vector3(45, 30, 400);

    public float speedRate = 5f;


    private void Awake()
    {
        transform.position = new Vector3(Random.Range(200, 1001), Random.Range(200, 1001), Random.Range(200, 1001));
    }


    private void Start()
    {
        //StartCoroutine(IncrementRandomSpeedRate());


    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, positionTarget, speedRate * Time.deltaTime);
    }


    IEnumerator IncrementRandomSpeedRate()
    {
        while (true)
        {
            //Valor de -2 a 3 para que seja incluso o 2
            int incrementSpeed = Random.Range(-2, 3);
            speedRate += incrementSpeed;

            //Valor de 200 a 801 para que seja incluso o 800
            int time = Random.Range(200, 801);
            
            yield return new WaitForSeconds(time/1000);
        }

    }


}
