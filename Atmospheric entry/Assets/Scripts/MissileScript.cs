using UnityEngine;
using System.Collections;

public class MissileScript : InteractiveObject {


    // Update is called once per frame
    void Update() {
        if (GetComponent<TurnInfo>().turnStart)
        {
            dest = loc + dir;
            Debug.Log("test");
            dir = GetComponent<ProjectionScript>().dest;
            loc = GetComponent<ProjectionScript>().dest;
            GetComponent<TurnInfo>().turnGauge = 0;
            GetComponent<TurnInfo>().turnStart = false;
        }
        HandleMovement();
    }
}
