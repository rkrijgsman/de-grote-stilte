using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject[] tilePrefabs;
    private Transform playerTransform;
    private float spawnY = 0.0f;
    private float tileLength = 9.6f;
    private float safeZone = 15f;
    private int amnTilesOnScreen = 4;

    private List<GameObject> activeTiles;
    // Start is called before the first frame update
    private void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
        
        for(int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
          
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(playerTransform.position.y  - safeZone > (spawnY - amnTilesOnScreen * tileLength))
        {
                SpawnTile();
                  DeleteTile ();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent (playerTransform);
        go.transform.position = Vector3.up * spawnY;
        spawnY += tileLength;
        activeTiles.Add (go);
    }
    private void DeleteTile()
    {
Destroy (activeTiles [0]);
activeTiles.RemoveAt (0);

    }
}
