using UnityEngine;
using System.Collections;

public class MenuButtonScript : MonoBehaviour {
    public Sprite normal;
    public Sprite highlit;
    public GameObject parent;
    public GameObject grandParent;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = highlit;
        if (Input.GetMouseButtonDown(0)) {
            grandParent.GetComponent<PlayerScript>().startMovement = true;
            grandParent.GetComponent<PlayerScript>().CloseMenu();
            

        }
    }

    void OnMouseExit() {
        GetComponent<SpriteRenderer>().sprite = normal;
    }
}
