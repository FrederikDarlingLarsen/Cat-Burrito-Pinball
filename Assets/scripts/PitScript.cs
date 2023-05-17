using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitScript : MonoBehaviour
{
    StatsManagerScript stats;
    
    void Start()
    {  
        stats = GameObject.Find("Stats Manager").GetComponent<StatsManagerScript>();
    }
    
    public void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("ball")){

            stats.LooseBall();

        }
    }
}
