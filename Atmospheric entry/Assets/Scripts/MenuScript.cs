using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
    public GameObject MenuButtonMove;
    GameObject localMenuButtonMove;
    public Sprite MoveButtonNormal;
    public Sprite MoveButtonHighlit;
    public GameObject parent;
    // Use this for initialization
    void Start () {
        localMenuButtonMove = Instantiate(MenuButtonMove);
        localMenuButtonMove.GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 1.1f, GetComponent<Transform>().position.y + 1.46f, 0);
        localMenuButtonMove.GetComponent<MenuButtonScript>().normal = MoveButtonNormal;
        localMenuButtonMove.GetComponent<MenuButtonScript>().highlit = MoveButtonHighlit;
        localMenuButtonMove.GetComponent<MenuButtonScript>().parent = gameObject;
        localMenuButtonMove.GetComponent<MenuButtonScript>().grandParent = parent;
        
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    
}
