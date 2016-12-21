using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {


	int value;
	public Item (int type)
	{
		value = type;
	}

	public int returnType(){
		return value;
	}

	public void setType(int type){
		value = type;
}

}
