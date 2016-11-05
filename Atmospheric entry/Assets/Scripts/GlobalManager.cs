using UnityEngine;
using System.Collections;

public class GlobalManager : MonoBehaviour {
    public static ModuleRoot heads;


	// Use this for initialization
	void Start () {
        heads = new ModuleRoot();
        heads.Load("Assets\\Modules\\head.xml");
        Debug.Log(heads.modules[0].name);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
