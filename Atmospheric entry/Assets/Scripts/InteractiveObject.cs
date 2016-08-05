using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour {
    public Vector2 dest;
    public Vector2 dir;
    public Vector2 loc;
    // Use this for initialization
    void Start () {
        GetComponentInParent<Transform>().position = loc;
        gameObject.AddComponent<TurnInfo>();
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

    
}
