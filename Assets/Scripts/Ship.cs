using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public tk2dTileMap[] tileMaps;
	// Use this for initialization
	IEnumerator Start () {
	    if (rigidbody2d == null)
	    {
	        rigidbody2d = GetComponent<Rigidbody2D>();
	    }

	    yield return null;

	    if (tileMaps == null)
	    {
	        tileMaps = GetComponentsInChildren<tk2dTileMap>();
	    }

        Debug.Log(tileMaps.Length);

        // Compute proper mass
	    var sum = 0;
	    foreach (var tileMap in tileMaps)
	    {
	        for (int i = 0; i < tileMap.Layers.Length; i++)
	        {
	            for (int x = 0; x < tileMap.width; x++)
	            {
	                for (int y = 0; y < tileMap.height; y++)
	                {
	                    sum += tileMap.GetTile(x, y, i) == -1 ? 0 : 1;
	                }
	            }
	        }
	    }

	    if (sum != 0)
	    {
            rigidbody2d.mass = sum;
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
