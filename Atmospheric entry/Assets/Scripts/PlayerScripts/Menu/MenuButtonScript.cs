using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class MenuButtonScript : MonoBehaviour
{
    public Sprite normal;
    public Sprite highlit;
    public GameObject parent;
    public GameObject grandParent;
    public string text;

    void OnGUI() {
        GUI.Label(new Rect(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, 100,20), text);
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().sprite = highlit;
        if (Input.GetMouseButtonDown(0))
        {
            OnClick();


        }
    }
    
    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().sprite = normal;
    }

    virtual public void OnClick() { }

}