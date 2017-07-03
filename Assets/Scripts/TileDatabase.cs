using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDatabase : MonoBehaviour {

	//Declare all the tiles to be used
	public GameObject tile1;
	public GameObject tile2;
	public GameObject tile3;
	public GameObject tile4;
	public GameObject tile5;
	public GameObject tile6;
	public GameObject tile7;
	public GameObject tile8;
	public GameObject tile9;
	public GameObject tile10;
	public GameObject tile11;
	public GameObject tile12;
	public GameObject tile13;
	public GameObject tile14;
	public GameObject tile15;
	public GameObject tile16;
	public GameObject tile17;
	public GameObject tile18;
	public GameObject tile19;
	public GameObject tile20;
	public GameObject tile21;
	public GameObject tile22;
	public GameObject tile23;

	//Create and empty List of game objects
	public List<GameObject> tiles = new List<GameObject> ();

	void Start(){
		//Add all the previously declared tiles to the empty List of game objects
		tiles.Add (tile1);
		tiles.Add (tile2);
		tiles.Add (tile3);
		tiles.Add (tile4);
		tiles.Add (tile5);
		tiles.Add (tile6);
		tiles.Add (tile7);
		tiles.Add (tile8);
		tiles.Add (tile9);
		tiles.Add (tile10);
		tiles.Add (tile11);
		tiles.Add (tile12);
		tiles.Add (tile13);
		tiles.Add (tile14);
		tiles.Add (tile15);
		tiles.Add (tile16);
		tiles.Add (tile17);
		tiles.Add (tile18);
		tiles.Add (tile19);
		tiles.Add (tile20);
		tiles.Add (tile21);
		tiles.Add (tile22);
	}
}
