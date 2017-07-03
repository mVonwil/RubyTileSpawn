using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorthTileCollision : MonoBehaviour {

	//Declare the script that contains all the tiles
	public TileDatabase tileDb;

	//Delcare the parent object of the cardinal direction colliders
	public GameObject levelGenerator;
	//Declare the transform of the LevelGenerator GameObject
	public Transform genPosition;
	//Declare the size of the tiles
	public float tileSize = 15f;
	//Declare the empty GameObject used to spawn tiles
	public GameObject spawner;
	//Declare the transform of the previous GameObject
	private Transform spawnerTransform;
	//Declare the empty GameObject used to remove tiles - must have a collider set to Trigger
	public GameObject tileRemover;
	//Declare the transform of the previous GameObject
	public Transform removerTransform;
	//Declare the size of the collider on the tileRemover
	public float removeSize;

	void Start(){
		//Find the script with all the tiles and assign it to tileDb
		tileDb = GameObject.FindGameObjectWithTag ("Database").GetComponent<TileDatabase> ();
		//Assign the transform of the LevelGenerator to genPosition
		genPosition = levelGenerator.gameObject.transform;
		//Assign the spawner GameObject in the scene to spawner
		spawner = GameObject.FindGameObjectWithTag ("Spawner");
		//Assign the transform of spawner to spawnerTransform
		spawnerTransform = spawner.GetComponent<Transform> ();
		//Assign the tileRemover GameObject in the scene to tileRemover
		tileRemover = GameObject.FindGameObjectWithTag("Remover");
		//Assign the transform of tileRemover to removerTransform
		removerTransform = tileRemover.GetComponent<Transform>();
		//Assign a value to removeSize - the +5 is an offset to ensure it only hits one row of tiles
		removeSize = tileSize + 5;
	}

	void OnTriggerEnter(Collider player){
		if (player.gameObject.tag == "Player") {
			//What direction is the player moving? - debug tells you
			Debug.Log ("North");
			//Move the spawner GameObject to the middle of the next row
			spawnerTransform.position = new Vector3 (spawnerTransform.position.x + tileSize, spawnerTransform.position.y, spawnerTransform.position.z);
			//Move the parent of the colliders to the next row
			genPosition.position = new Vector3 (genPosition.position.x + tileSize, genPosition.position.y, genPosition.position.z);
			//Spawn a tile at the centre of the spawner
			Instantiate (tileDb.tiles[Random.Range(0, tileDb.tiles.Count)], new Vector3 (spawnerTransform.position.x - 7.5f, spawnerTransform.position.y, spawnerTransform.position.z - 7.5f), Quaternion.identity);
			//Spawn a tile next to the first tile
			Instantiate (tileDb.tiles[Random.Range(0, tileDb.tiles.Count)], new Vector3 (spawnerTransform.position.x - 7.5f, spawnerTransform.position.y, (spawnerTransform.position.z - 7.5f) + tileSize), Quaternion.identity);
			//Spawn a tile on the opposite side of the first tile
			Instantiate (tileDb.tiles[Random.Range(0, tileDb.tiles.Count)], new Vector3 (spawnerTransform.position.x - 7.5f, spawnerTransform.position.y, (spawnerTransform.position.z - 7.5f) - tileSize), Quaternion.identity);
			//Move the spawner to the centre of the LevelGenerator GameObject
			spawnerTransform.localPosition = Vector3.zero;
			//Move the tileRemover so that it is opposite to the spawner
			removerTransform.position = new Vector3 (removerTransform.position.x - (removeSize * 2), 0, removerTransform.position.z);
		}
	}
}