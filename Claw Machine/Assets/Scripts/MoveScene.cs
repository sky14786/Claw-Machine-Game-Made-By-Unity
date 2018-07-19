using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour {

	public void MoveStart()
    {
        SceneAdmin.Instance.StartScene();
    }
    public void MoveMain()
    {
        SceneAdmin.Instance.MainScene();
    }
}
