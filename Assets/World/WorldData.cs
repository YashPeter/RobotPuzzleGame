using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WorldData {
	int currentplayer;
	int currentsplitter1;
	Player[] playables;
	MapData [,] map;
	Splitter[] splitters;
	Action<int, int, int, int> upf;
	Action<int, float, float, int> upp;
	Action<float,float,float,float> upb;

	public WorldData(Action<int, int, int, int> upf, Action<int, float, float, int> upp) {
		currentsplitter1 = 0;
		upb = updatepos;
		splitters = new Splitter[100];
		playables = new Player[6];
		map = new MapData[1000, 1000];
		for (int i = 0; i < 1000; i++) {
			for (int t = 0; t < 1000; t++) {
				map [i, t] = new MapData(0,0);
			}
		}

		currentplayer = 0;
		upb = updatepos;
		this.upf = upf;
		this.upp = upp;

	}

	//methods that allow world controller to directly interact with the player movement//
	public void updatepos(float oldx, float oldy, float newx, float newy){
		map [(int)oldx + 500, (int)oldy + 500].setItemType(0);
		map [(int)newx+500, (int)newy+500].setItemType(1);
        
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
			if (map [(int)playables [xp].getposx() +500,(int)playables [xp].getposy() +499].returnItemType() == 1) {
				Debug.Log ("going down but object in way");
			} else {
				Debug.Log ("going down");
				playables[xp].move();
			}
			break;
		case 1:
			if (map [(int)playables [xp].getposx() + 501,(int)playables [xp].getposy()+500].returnItemType() == 1) {
				Debug.Log ("going right but object in way");
			} else {
				Debug.Log ("going right");
				playables[xp].move();
			}
			break;

		case 2:
			if (map [(int)playables [xp].getposx()+500,(int)playables [xp].getposy() + 501].returnItemType() == 1) {
				Debug.Log ("going up but object in way");
			} else {
				Debug.Log ("going up");
				playables[xp].move();
			}
			break;

		case 3:
			if (map [(int)playables [xp].getposx() +499,(int)playables [xp].getposy()+500].returnItemType() == 1) {
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
		playables[currentplayer] = new Player(currentplayer, 0, 5, currentplayer + 1,upf,upp,upb, 2);
		currentplayer += 1;

	}

	public int returnAmount(){
        return currentplayer;
	}

	public void AddSplitter(int amount){
		splitters [currentsplitter1] = new Splitter (amount);
	}

	public void addExit(float x, float y){
		splitters [currentsplitter1].addExit (new SplitterEx(x,y));
	}

	public void setEntrance(float x, float y){
		splitters [currentsplitter1].setEntrance (new SplitterE(x,y));
	}

	public void setGearPad(float x, float y){
		splitters [currentsplitter1].setGearPad (new GearPad (x, y));
	}


}