using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class massSpawn : MonoBehaviour
{

    public GameObject ObsticlePreafab;
    //  plaier staðsetning
    public Transform player;
   // private Vector3 movement;
    //  stðurin þar sem óvinur spawnar
    private Vector3 spawnPosOfset = new Vector3(10, 15, 15);
    
    private float repeatRate = 30;


   
    void Start()
    {
        
        StartCoroutine("BallBall");
    }

    // Update is called once per frame

    void Update()
    {
    
        
    }



     public IEnumerator BallBall()
    {
        repeatRate = 30;
        repeatRate = repeatRate - rememberMe.SpawnHraði;
        
        int someValue = Random.Range(0, 2) * 2 - 1;
        int num = Random.Range(20, 500 * someValue);
        someValue = Random.Range(0, 2) * 2 - 1;
        int num2 = Random.Range(20, 500 * someValue);
        spawnPosOfset = new Vector3(num, 100, num2);
        Instantiate(ObsticlePreafab, player.position+ spawnPosOfset, ObsticlePreafab.transform.rotation);

        yield return new WaitForSeconds(repeatRate);

        //BallBall();
        StartCoroutine("BallBall");

        //InvokeRepeating("spawnobsticle", startDelay, repeatRate);

    }
}
