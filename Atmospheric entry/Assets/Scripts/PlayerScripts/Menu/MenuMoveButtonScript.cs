using UnityEngine;
using System.Collections;

public class MenuMoveButtonScript : MenuButtonScript {

    public override void OnClick()
    {
        base.OnClick();
        grandParent.GetComponent<PlayerScript>().startMovement = true;
        grandParent.GetComponent<PlayerScript>().CloseMenu();
    }

}
