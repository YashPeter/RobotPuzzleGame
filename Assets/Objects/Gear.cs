using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear{
	int value;
	public Gear(int value){
		this.value = value;
	}
	
	public int returnValue(){
		return value;
	}

	public void setValue(int value){
		this.value = value;
	}
}
