using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour {

	public void MoveStart()
    {
        SceneAdmin.instance.StartScene();
    }
    public void MoveMain()
    {
        SceneAdmin.instance.MainScene();
    }
}
