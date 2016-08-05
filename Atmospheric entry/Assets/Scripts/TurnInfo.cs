using UnityEngine;
using System.Collections;

public class TurnInfo : MonoBehaviour {
    public int speed;
    public int turnGauge;
    public bool turnEnd = false;
    public bool inTurn = false;
    public bool turnStart = false;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void applySpeed()
    {
        turnGauge += speed;
    }
}
