using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}

	public void ChangeScene(string scene)
	{
		Application.LoadLevel (scene);
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
