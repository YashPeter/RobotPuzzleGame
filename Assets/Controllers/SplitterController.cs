using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SplitterController : MonoBehaviour {

	//Importanting Sprites
	public Sprite entrance;
	public Sprite exit;
	public Sprite gearpad;

	public static SplitterController Instance { get; protected set; }

	int currententrance;
	int currentexit;
	int currentgearpad;

	GameObject [] gearpadObject;
	GameObject [] entranceObject;
	GameObject [] exitObject;
	SpriteRenderer [] gearpadSprite;
	SpriteRenderer [] entranceSprite;
	SpriteRenderer [] exitSprite;

	public Action<float, float> startentrance;
	public Action<float, float> startexit;
	public Action<float, float> startgear;

	void Start () {
		Instance = this;
		//set ups actions
		startentrance = startEntrance;
		startexit = startExit;
		startgear = startGearPad;



		currententrance = 0;
		currentexit = 0;
		currentgearpad = 0;
		gearpadObject = new GameObject [100];
		entranceObject = new GameObject [100];
		exitObject = new GameObject [100];

		gearpadSprite = new SpriteRenderer[100];
		entranceSprite = new SpriteRenderer[100];
		exitSprite = new SpriteRenderer[100];
	}

	public Action<float,float> returnStartEntrance(){
		return startentrance;
	}

	public Action<float,float> returnStartExit(){
		return startexit;
	}

	public Action<float,float> returnStartGear(){
		return startgear;
	}

	public void startEntrance(float x, float y){
		entranceObject [currententrance] = new GameObject ();
		entranceObject[currententrance].AddComponent<SpriteRenderer>();
		entranceSprite[currententrance] = new SpriteRenderer();
		entranceSprite[currententrance] = entranceObject[currententrance].GetComponent<SpriteRenderer>();
		entranceSprite [currententrance].sprite = entrance;
		entranceObject [currententrance].transform.position = new Vector3(x, y, 0);
		currententrance += 1;
	}

	public void startExit(float x, float y){
		exitObject [currentexit] = new GameObject ();
		exitObject[currentexit].AddComponent<SpriteRenderer>();
		exitSprite[currentexit] = new SpriteRenderer();
		exitSprite[currentexit] = exitObject[currentexit].GetComponent<SpriteRenderer>();
		exitSprite [currentexit].sprite = exit;
		exitObject [currentexit].transform.position = new Vector3(x, y, 0);
		currentexit += 1;
	}

	public void startGearPad(float x, float y){
		gearpadObject [currentgearpad] = new GameObject ();
		gearpadObject[currentgearpad].AddComponent<SpriteRenderer>();
		gearpadSprite[currentgearpad] = new SpriteRenderer();
		gearpadSprite[currentgearpad] = gearpadObject[currentgearpad].GetComponent<SpriteRenderer>();
		gearpadSprite [currentgearpad].sprite = gearpad;
		gearpadObject [currentgearpad].transform.position = new Vector3(x, y, 0);
		currentgearpad += 1;
	}
}