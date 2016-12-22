using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitter{
	
	//inicalizes entrances and exits
	SplitterE entrance;
	SplitterEx [] exits;
	GearPad pad;
	int currentexit;

	public Splitter(int amount){
		exits = new SplitterEx[amount];
		currentexit = 0;
	}

	public void addExit(SplitterEx newexit){
		exits [currentexit] = newexit;
	}

	public void setEntrance(SplitterE newentrance){
		entrance = newentrance;
	}

	public void setGearPad(GearPad newpad){
		pad = newpad;
	}

	public float returnGearX(){
		return pad.returnX ();
	}

	public float returnGearY(){
		return pad.returnY ();
	}

	public float returnEntranceX(){
		return entrance.returnX ();
	}

	public float returnEntranceY(){
		return entrance.returnY ();
	}

	public float returnExitsX(int index){
		return exits [index].returnX ();
	}

	public float returnExitsY(int index){
		return exits [index].returnY ();
	}


}
