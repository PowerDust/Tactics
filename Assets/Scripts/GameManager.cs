﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour {
	public Grid grid;
	public Tilemap tilemap;

	// Use this for initialization
	void Start () {
		//float tileColLength = (float) tilemap.cellBounds.size.y;
		//float halfCellSize = ((float)grid.cellSize.y) / 2;
		//(GetComponentInParent (typeof(Camera)) as Camera).orthographicSize = tileColLength*halfCellSize;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
