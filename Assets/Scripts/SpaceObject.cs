using UnityEngine;
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
        var parent = transform.parent;
        Ship ship = null;
        while (parent != null && (ship = parent.gameObject.GetComponent<Ship>()) == null)
        {
            parent = parent.parent;
        }
        return ship;
    }
}
