using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WorldController : MonoBehaviour {

	//allows other controllers to access this class, handy//
	public static WorldController Instance { get; protected set; }

	//sets up an instance so the playerdisplay can access this/
	public WorldData World { get; protected set; }

	//action iniciated//
	Action <int, int, int, int> upf;
	Action<int, float, float, int> upp;


	void Start () {


		//sets up actions from playercontroller to be sent to player objects using player controller instance//
		upf = PlayerController.Instance.returnUPF();

		upp = PlayerController.Instance.returnUPP();

		//sets instance to this specific version//
		Instance = this;
		//sets up world data//
		World = new WorldData(upf, upp);

		//add a player, just for testing//
		World.AddPlayer();

	}

	// Update is called once per frame
	void Update () {

		//work in progress//
		if (Input.GetKeyUp("s")) {
			if (World.ReturnPlayerDirection(0) != 0 )
			{
				World.SetPlayerDirection(0, 0);
			}
			else
			{
				World.MovePlayer(0);
			}
		}
		if (Input.GetKeyUp("d")) {
			if (World.ReturnPlayerDirection(0) != 1)
			{
				World.SetPlayerDirection(0, 1);
			}
			else
			{
				World.MovePlayer(0);
			}
		}
		if (Input.GetKeyUp("w")) {
			if (World.ReturnPlayerDirection(0) != 2)
			{
				World.SetPlayerDirection(0, 2);
			}
			else
			{
				World.MovePlayer(0);
			}
		}
		if (Input.GetKeyUp("a")) {
			if (World.ReturnPlayerDirection(0) != 3)
			{
				World.SetPlayerDirection(0, 3);
			}
			else
			{
				World.MovePlayer(0);
			}
		}

	}
}