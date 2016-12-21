using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WorldData {
	int currentplayer;
	Player[] playables;
	Item [,] map;
	Action<int, int, int, int> upf;
	Action<int, float, float, int> upp;
	Action<float,float,float,float> upb;

	public WorldData(Action<int, int, int, int> upf, Action<int, float, float, int> upp) {
		upb = updatepos;
		playables = new Player[6];
		map = new Item[1000, 1000];
		for (int i = 0; i < 1000; i++) {
			for (int t = 0; t < 1000; t++) {
				map [i, t] = new Item (0);
			}
		}

		currentplayer = 1;
		upb = updatepos;
		this.upf = upf;
		this.upp = upp;

	}

	//methods that allow world controller to directly interact with the player movement//
	public void updatepos(float oldx, float oldy, float newx, float newy){
		map [(int)oldx + 500, (int)oldy + 500].setType(0);
		map [(int)newx+500, (int)newy+500].setType(2);
		Debug.Log (map [(int)oldx +500, (int)oldy + 500].returnType());
		Debug.Log (map [(int)newx +500, (int)newy +500].returnType());
	}

	public int ReturnPlayerDirection(int xp)
	{
		return playables[xp].getdirection();
	}

	public void updatepos(int pt){

	}

	public void SetPlayerDirection(int xp, int xd)
	{
		playables[xp].setdirection(xd);
	}

	public void MovePlayer(int xp)
	{
		switch (playables [xp].getdirection()) {
		case 0:
			if (map [(int)playables [xp].getposx() +500,(int)playables [xp].getposy() +499].returnType() == 2) {
				Debug.Log ("going down but object in way");
			} else {
				Debug.Log ("going down");
				playables[xp].move();
			}
			break;
		case 1:
			if (map [(int)playables [xp].getposx() + 501,(int)playables [xp].getposy()+500].returnType() == 2) {
				Debug.Log ("going right but object in way");
			} else {
				Debug.Log ("going right");
				playables[xp].move();
			}
			break;

		case 2:
			if (map [(int)playables [xp].getposx()+500,(int)playables [xp].getposy() + 501].returnType() == 2) {
				Debug.Log ("going up but object in way");
			} else {
				Debug.Log ("going up");
				playables[xp].move();
			}
			break;

		case 3:
			if (map [(int)playables [xp].getposx() +499,(int)playables [xp].getposy()+500].returnType() == 2) {
				Debug.Log ("going left but object in way");
			} else {
				Debug.Log ("going left");
				playables[xp].move();
			}
			break;
		}


	}


	public void AddPlayer()
	{
		playables[currentplayer - 1] = new Player(currentplayer - 1, 0, 5, currentplayer,upf,upp,upb, 2);
		currentplayer += 1;

	}

	public int returnAmount(){
		return playables.Length;
	}



}