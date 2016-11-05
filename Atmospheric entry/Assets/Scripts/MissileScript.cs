using UnityEngine;
using System.Collections;

public class MissileScript : InteractiveObject {
    bool goingToHit = false;
    GameObject collidedWith;

    // Update is called once per frame
    void Update() {
        if (GetComponent<TurnInfo>().turnStart)
        {
            turnStartLoc = loc;
            dest = loc + dir;
            localProjection = Instantiate(projection);
            localProjection.GetComponent<Transform>().position = dest;
            localProjection.GetComponent<SpriteRenderer>().sprite = GetComponent<SpriteRenderer>().sprite;
            localProjection.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .5f);
            localProjection.GetComponent<ProjectionScript>().dest = dest;
            localProjection.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);

            Vector2 heading = localProjection.GetComponent<Transform>().position - GetComponent<Transform>().position;
            RaycastHit2D hit = Physics2D.Raycast(GetComponent<Transform>().position, heading, heading.magnitude);
            if (hit.collider != null && hit.collider.GetComponent<InteractiveObject>().dest == new Vector2(hit.collider.GetComponent<Transform>().position.x, hit.collider.GetComponent<Transform>().position.y)) {
                goingToHit = true;
                dest = hit.collider.GetComponent<Transform>().position;
                Debug.Log("raycast hit");
                collidedWith = hit.collider.gameObject;
            }

            dir = dest - turnStartLoc;
            loc = dest;
            GetComponent<TurnInfo>().turnGauge = 0;
            GetComponent<TurnInfo>().turnStart = false;
        }

        if (localProjection != null) {
            Debug.DrawLine(GetComponent<Transform>().position, localProjection.GetComponent<Transform>().position);
            if (GetComponent<Transform>().position == localProjection.GetComponent<Transform>().position)
            {
                Destroy(localProjection);
            }
        }

        HandleCollision();

        HandleMovement();
    }


    void HandleCollision()
    {
        if (goingToHit && new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y) == dest) {
            collidedWith.GetComponent<StatScript>().HP -= 10;
            Destroy(localProjection);
            RemoveFromGame();
            Destroy(gameObject);
        }
    }
}
