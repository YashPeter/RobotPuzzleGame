using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player{
	//inciating positions, direct, frame and limit frame, type of player for referencing sprites//
	float posx;
	float posy;
	int direction;
	int frame;
	int framelimit;
	int pt;
	playernum type;
	int gear;

	// enum //
	public enum playernum {Player1, Player2, Player3, Player4, Player5, Player6 };

	//actions//
	Action<int, int, int, int> upf;
	Action<int, float, float, int> upp;
	Action<float,float,float,float> upb;


	//constructor//
	public Player(float posx, float posy, int framelimit, int pt, Action<int, int, int, int> upf, Action<int, float, float, int> upp, Action<float, float, float ,float> upb, int gear)
	{
		this.posx = posx;
		this.posy = posy;
		direction = 0;
		frame = 1;
		this.framelimit = framelimit;
		this.upf = upf;
		this.upp = upp;
		this.upb = upb;
		this.pt = pt;
		Debug.Log ("player inicilized");
		this.gear = gear;
		this.iniciate ();



		//switch case to set enum type//
		switch (pt)
		{
		case 1:
			type = playernum.Player1;
			break;
		case 2:
			type = playernum.Player2;
			break;
		case 3:
			type = playernum.Player3;
			break;
		case 4:
			type = playernum.Player4;
			break;
		case 5:
			type = playernum.Player5;
			break;
		case 6:
			type = playernum.Player6;
			break;
		}
	}
	public float getposx(){
		return posx;
	}

	public float getposy(){
		return posy;
	}
		

	public int getdirection(){
		return direction;
	}

	public int getframe(){
		return frame;
	}

	public void iniciate(){
		upf(pt - 1, frame, direction, pt);
		upp(pt - 1, posx, posy, direction);
        upb(posx, posy, posx, posy);
	}

	//moves the player depending on their direction//
	public void move(){
		switch (direction) {
		case 0:
			posy -= 1;
			updateframe ();
			upb (posx, posy + 1, posx, posy);

			break;	
		case 1:
			posx += 1;
			updateframe ();
			upb (posx - 1, posy, posx, posy);
			break;	
		case 2:
			posy += 1;
			updateframe ();
			upb (posx, posy - 1, posx, posy);
			break;	
		case 3:
			posx -= 1;
			updateframe ();
			upb (posx + 1, posy, posx, posy);
			break;	
		}
	}

	public void updateframe(){
		if (frame == framelimit) {

			frame = 1;

			upf(pt- 1, frame, direction, pt);
			upp(pt - 1, posx, posy, direction);
		} else {

			frame += 1;
			upf(pt - 1, frame, direction, pt);
			upp(pt - 1, posx, posy, direction);
		}
	}

	public void setdirection(int direction){
		this.direction = direction;
		upf(pt - 1, frame, direction, pt);
	}
}