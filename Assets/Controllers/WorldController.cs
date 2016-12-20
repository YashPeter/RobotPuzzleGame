using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WorldController : MonoBehaviour
{

    //allows other controllers to access this class, handy//
    public static WorldController Instance { get; protected set; }

    //sets up an instance so the playerdisplay can access this/
    public WorldData World { get; protected set; }

    //action iniciated//
    Action<int, int, int, int> upf;
    Action<int, float, float, int> upp;

	int [] playercontrols;
	int currentplayer;


    void Start()
    {
		currentplayer = 0;
		playercontrols = new int[6];
        upf = PlayerController.Instance.returnUPF();
        upp = PlayerController.Instance.returnUPP();

        Instance = this;
        World = new WorldData(upf, upp);
        //sets up actions from playercontroller to be sent to player objects using player controller instance//
      

        //sets instance to this specific version//

        //sets up world data//


        //add a player, just for testing//
        World.AddPlayer();
		World.AddPlayer ();

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyUp ("left")) {
			if (currentplayer != 0) {
				currentplayer -= 1;
			}
		}
		if (Input.GetKeyUp ("right")) {
			if (World.returnAmount() - 1 > currentplayer) {
				currentplayer += 1;
			}
		}
        
        if (Input.GetKeyUp("s"))
        {
            if (World.ReturnPlayerDirection(currentplayer) != 0)
            {
				World.SetPlayerDirection(currentplayer, 0);
            }
            else
            {
				World.MovePlayer(currentplayer);
            }
        }
        if (Input.GetKeyUp("d"))
        {
			if (World.ReturnPlayerDirection(currentplayer) != 1)
            {
				World.SetPlayerDirection(currentplayer, 1);
            }
            else
            {
				World.MovePlayer(currentplayer);
            }
        }
        if (Input.GetKeyUp("w"))
        {
			if (World.ReturnPlayerDirection(currentplayer) != 2)
            {
				World.SetPlayerDirection(currentplayer, 2);
            }
            else
            {
				World.MovePlayer(currentplayer);
            }
        }
        if (Input.GetKeyUp("a"))
        {
			if (World.ReturnPlayerDirection(currentplayer) != 3)
            {
				World.SetPlayerDirection(currentplayer, 3);
            }
            else
            {
				World.MovePlayer(currentplayer);
            }
        }

    }

    
}