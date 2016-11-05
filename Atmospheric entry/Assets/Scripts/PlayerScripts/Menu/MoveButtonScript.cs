using UnityEngine;
using System.Collections;

public class MoveButtonScript : MonoBehaviour {

    // Use this for initialization
    public GameObject parent;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnMouseOver() {
        
        if (Input.GetMouseButtonDown(0))
        {
            parent.GetComponent<ProjectionScript>().dest = GetComponent<Transform>().position;
        }
    }
}
