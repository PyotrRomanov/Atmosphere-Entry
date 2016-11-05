using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StatScript : MonoBehaviour {
    public int HP;
    public List<string> equipped;
    public List<Module> hardPoints;

	// Use this for initialization
	void Start () {
        hardPoints = new List<Module>();
        //hardPoints.Add(new Module("head", "Basic Head"));
        GlobalManager.heads.modules.Find(mod => string.Equals(mod.name, "a"));
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
