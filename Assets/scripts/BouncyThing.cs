using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyThing : MonoBehaviour
{
    StatsManagerScript stats;

    // Start is called before the first frame update
    void Start()
    {
        stats = GameObject.Find("Stats Manager").GetComponent<StatsManagerScript>();
    }

    public void OnCollisionEnter(Collision collision){
            stats.AddPoints(100);
    }
}
