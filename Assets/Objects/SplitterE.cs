using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitterE{
	float posx;
	float posy;
	public SplitterE(float x, float y){
		posx = x;
		posy = y;
	}

	public float returnX(){
		return posx;
	}

	public float returnY(){
		return posy;
	}

}
