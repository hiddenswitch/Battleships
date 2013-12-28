using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Drill : SpaceObject
{
    public float efficiency;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var tileMaps = collision.gameObject.GetComponentsInChildren<tk2dTileMap>();
        int x = 0;
        int y = 0;
        foreach (var tileMap in tileMaps)
        {
            var tileMapDirty = false;
            foreach (var contact in collision.contacts)
            {
                var position = contact.point + 0.08f*(Vector2)(transform.rotation * Vector2.up);

                if (tileMap.GetTileAtPosition(position, out x, out y))
                {
                    tileMap.SetTile(x, y, 0, -1);
                    tileMapDirty = true;
                }
            }
            if (tileMapDirty)
            {
                StartCoroutine(RebuildTileMap(tileMap));
            }
        }
    }

    IEnumerator RebuildTileMap(tk2dTileMap tileMap)
    {
        yield return new WaitForEndOfFrame();
        tileMap.Build();
        yield break;
    }
}
