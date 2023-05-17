using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreFloorScript : MonoBehaviour
{
    Animator floorAnim;
    StatsManagerScript stats;
    
    void Start()
    {
        stats = GameObject.Find("Stats Manager").GetComponent<StatsManagerScript>();

        floorAnim = gameObject.GetComponent<Animator>();
    }

    public void OnTriggerExit(Collider other){

        if(other.gameObject.CompareTag("ball")){
        stats.AddPoints(50);

        floorAnim.Play("lightUp");
 }
    }
}
