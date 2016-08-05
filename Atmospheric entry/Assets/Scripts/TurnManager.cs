using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnManager : MonoBehaviour {
    GameObject[] objects;
    Queue<GameObject> nextTurns = new Queue<GameObject>();
    // Use this for initialization
    void Start () {
        objects = GameObject.FindGameObjectsWithTag("TakesTurns");

    }
	
	// Update is called once per frame
	void Update () {

        if (nextTurns.Count == 0)
        {   
            if (checkTurns())
            {
                
                while (checkGauges())
                {
                    foreach (GameObject p in objects)
                    {
                        p.GetComponent<PlayerScript>().applySpeed();
                        if (p.GetComponent<PlayerScript>().turnGauge > 100)
                        {
                            //p.GetComponent<PlayerScript>().turnGauge = 0;
                            nextTurns.Enqueue(p);
                        }
                    }
                }
            }
        }
        else {
            GameObject curPlayer = nextTurns.Dequeue();
            curPlayer.GetComponent<PlayerScript>().turnStart = true;
        }
        
	}

    bool checkTurns() {
        foreach (GameObject p in objects) {
            if (p.GetComponent<PlayerScript>().inTurn) {
                return false;
            }
        }
        return true;
    }

    bool checkGauges() {
        foreach (GameObject p in objects) {
            if (p.GetComponent<PlayerScript>().turnGauge > 100) {
                return false;
            }
        }
        return true;
    }
}
