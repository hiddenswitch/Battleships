﻿using UnityEngine;
using System.Collections;

public class SpaceObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Ship FindShip()
    {
        return this.GetComponentInParents<Ship>();
    }
}
