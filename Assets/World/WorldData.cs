using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WorldData {
	int currentplayer;
	Player[] playables;
	Action<int, int, int, int> upf;
	Action<int, float, float, int> upp;

	public WorldData(Action<int, int, int, int> upf, Action<int, float, float, int> upp) {
		playables = new Player[6];
		currentplayer = 1;
		this.upf = upf;
		this.upp = upp;

	}

	//methods that allow world controller to directly interact with the player movement//
	public int ReturnPlayerDirection(int xp)
	{
		return playables[xp].getdirection();
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
		playables[currentplayer - 1] = new Player(0, 0, 5, currentplayer,upf,upp);

	}



}