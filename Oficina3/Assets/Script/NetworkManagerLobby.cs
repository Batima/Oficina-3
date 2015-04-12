using UnityEngine;
using System.Collections;

public class NetworkManagerLobby : MonoBehaviour 
{
	private const string GameName = "Rio450Graus";
	private const string RoomName = "RoomName";

	// Use this for initialization
	void Start () 
	{
	
	}

	public void StartServer()
	{
		Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
		MasterServer.RegisterHost(GameName, RoomName);
	}

	void OnServerInitialized()
	{
		Debug.Log("Server Initializied");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
