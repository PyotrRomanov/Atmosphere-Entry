using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour {
    public Vector2 dest;
    public Vector2 dir;
    public Vector2 loc;
    protected Vector2 turnStartLoc;
    public int speed;
    public GameObject projection;
    protected GameObject localProjection;
    // Use this for initialization
    void Start () {
        GetComponentInParent<Transform>().position = loc;
        gameObject.AddComponent<TurnInfo>();
        GetComponent<TurnInfo>().speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected void HandleMovement()
    {
        if (new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y) != dest)
        {
            GetComponentInParent<Transform>().position = Vector3.MoveTowards(GetComponentInParent<Transform>().position, dest, 3 * Time.deltaTime);

        }
    }

    protected void RemoveFromGame() {
        GameObject turnManager = GameObject.FindGameObjectWithTag("GlobalManager");
        turnManager.GetComponent<TurnManager>().objects.Remove(gameObject);
    }
    
}
