using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System;

public class Module {
    [XmlElement("name")]
    public string name;

    public string type;

    [XmlElement("HP")]
    public int HP;

    [XmlElement("active")]
    public bool activeAbility;


    // Use this for initialization
    public Module() {
    }
    

	// Update is called once per frame
	void Update () {
	
	}
}
