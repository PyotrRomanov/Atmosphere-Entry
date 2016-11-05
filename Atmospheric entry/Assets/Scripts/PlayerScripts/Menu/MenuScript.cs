using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
    public GameObject MenuButtonMove;
    GameObject localMenuButtonMove;
    public Sprite MoveButtonNormal;
    public Sprite MoveButtonHighlit;

    GameObject localMenuButtonWeapon;

    public GameObject parent;
    // Use this for initialization
    void Start () {
        localMenuButtonMove = Instantiate(MenuButtonMove);
        localMenuButtonMove.GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 1.1f, GetComponent<Transform>().position.y + 1.46f, 0);
        localMenuButtonMove.GetComponent<MenuMoveButtonScript>().normal = MoveButtonNormal;
        localMenuButtonMove.GetComponent<MenuMoveButtonScript>().highlit = MoveButtonHighlit;
        localMenuButtonMove.GetComponent<MenuMoveButtonScript>().parent = gameObject;
        localMenuButtonMove.GetComponent<MenuMoveButtonScript>().grandParent = parent;
        localMenuButtonMove.GetComponent<MenuMoveButtonScript>().text = "test";

        
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    
}
