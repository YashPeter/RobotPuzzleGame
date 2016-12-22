using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    //numerical value representing item type:
    //0: no item
    //1: player
    //more later
    int value;

    //contructor asking for item type 
	public Item (int type)
	{
		value = type;
	}

    //returns the type
	public int returnType(){
		return value;
	}

    //sets the type
	public void setType(int type){
		value = type;
}

}
