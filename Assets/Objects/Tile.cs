using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    //numerical value representing tile type:
    //0: blank space
    //1: barrier
    //2: splitter entrance
    //3: splitter exit
    //more later
    int value;

    //contructor asking for the type
	public Tile(int type)
    {
        value = type;

    }

    //returns the type
    public int returnType()
    {
        return value;
    }

    //sets the type
    public void setType(int type)
    {
        value = type;
    }
}
