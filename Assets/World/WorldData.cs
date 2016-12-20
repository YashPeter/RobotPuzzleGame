using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WorldData {
	int currentplayer;
	Player[] playables;
	Boolean [,] map;
	Action<int, int, int, int> upf;
	Action<int, float, float, int> upp;
	Action<float,float,float,float> upb;

	public WorldData(Action<int, int, int, int> upf, Action<int, float, float, int> upp) {
		upb = updatepos;
		playables = new Player[6];
		map = new Boolean[1000, 1000];

		currentplayer = 1;
		upb = updatepos;
		this.upf = upf;
		this.upp = upp;

	}

	//methods that allow world controller to directly interact with the player movement//
	public void updatepos(float oldx, float oldy, float newx, float newy){
		map [(int)oldx, (int)oldy] = false;
		map [(int)newx, (int)newy] = true;
		Debug.Log (map [(int)oldx, (int)oldy]);
		Debug.Log (map [(int)newx, (int)newy]);
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
		playables[xp].move();
	}


	public void AddPlayer()
	{
		playables[currentplayer - 1] = new Player(0, 0, 5, currentplayer,upf,upp,upb);
		currentplayer += 1;

	}

	public int returnAmount(){
		return playables.Length;
	}



}