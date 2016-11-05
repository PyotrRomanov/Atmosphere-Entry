using UnityEngine;
using System.Collections;

public class ProjectionScript : MonoBehaviour {
    public Vector2 dest;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        HandleMovement();

	}


    protected void HandleMovement()
    {
        if (new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y) != dest)
        {
            GetComponentInParent<Transform>().position = Vector3.MoveTowards(GetComponentInParent<Transform>().position, dest, 3 * Time.deltaTime);

        }
    }

}
