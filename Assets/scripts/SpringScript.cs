using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
    StatsManagerScript stats;

    void Start(){
        stats = GameObject.Find("Stats Manager").GetComponent<StatsManagerScript>();
    }
    public void OnCollisionEnter(Collision collision){

        collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        stats.AddPoints(500);
    }
}
