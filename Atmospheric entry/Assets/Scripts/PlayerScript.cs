using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : InteractiveObject {
    // grid is 25x18
    // universal scale is 3.125
    public GameObject projection;
    GameObject localProjection;
    public GameObject moveButton;
    public GameObject menu;
    GameObject localMenu;
    public bool menuOpen = false;
    public bool startMovement = false;
    Vector2 turnStartLoc;
    public int teamID;

    public int speed;
    public int turnGauge;
    public bool turnEnd = false;
    public bool inTurn = false;
    public bool turnStart = false;

    // Update is called once per frame
    void Update () {
        

        if (turnStart)
        {
            menuOpen = true;
            inTurn = true;
            turnStart = false;
            localProjection = Instantiate(projection);
            localProjection.GetComponent<ProjectionScript>().dest = loc + dir;
            localProjection.GetComponent<Transform>().position = GetComponent<Transform>().position;
            localProjection.GetComponent<SpriteRenderer>().sprite = GetComponent<SpriteRenderer>().sprite;
            localProjection.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .5f);
        }

        HandleMenu();
        CreateMovementButtons();
        HandleMovement();


        //Endturn hotkey code
        if (Input.GetKeyDown("space") && inTurn) {
            dest = localProjection.GetComponent<ProjectionScript>().dest;
            turnGauge = 0;
            loc = localProjection.GetComponent<ProjectionScript>().dest;
            dir = localProjection.GetComponent<ProjectionScript>().dest - turnStartLoc;
            GameObject[] moveButtons = GameObject.FindGameObjectsWithTag("MoveButton");
            foreach (GameObject m in moveButtons) {
                Destroy(m);
            }
            Destroy(localProjection);
            CloseMenu();
            inTurn = false;
            
        }
        
    }

    void HandleMenu() {
       
        if (menuOpen) {
            localMenu = Instantiate(menu);
            localMenu.GetComponent<MenuScript>().parent = gameObject;
            localMenu.GetComponent<Transform>().position = loc + new Vector2(2.5f,-1.5f);
            menuOpen = false;
        }
        if (inTurn && Input.GetMouseButtonDown(1)) {
            GameObject[] moveButtons = GameObject.FindGameObjectsWithTag("MoveButton");
            foreach (GameObject m in moveButtons)
            {
                Destroy(m);
            }
            menuOpen = true;
        }
    }

    public void CloseMenu() {
        GameObject[] menuButtons = GameObject.FindGameObjectsWithTag("MenuButton");
        foreach (GameObject m in menuButtons)
        {
            Destroy(m);
        }
        Destroy(localMenu);
    }

    void CreateMovementButtons() {
        if (startMovement) {

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    GameObject mvButton = Instantiate(moveButton);
                    mvButton.GetComponent<Transform>().position = new Vector2(loc.x + dir.x + x, loc.y + dir.y + y);
                    mvButton.GetComponent<MoveButtonScript>().parent = localProjection;
                    
                }
            }

            turnStartLoc = loc;
            startMovement = false;
        }
        
    }

    public void applySpeed()
    {
        turnGauge += speed;
    }


}
