using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public Texture2D map;
    public ColorToPrefab[] tiles;
	void Start () {
        GenerateLevel();
	}
	
    void GenerateLevel()
    {
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x, y);
            }
        }
    }

    void GenerateTile(int x, int y)
    {
        Color pixelColor = map.GetPixel(x, y);

        if(pixelColor.a == 0)
        {
            return;
        }
        foreach(ColorToPrefab colorMap in tiles)
        {
            if (colorMap.color.Equals(pixelColor))
            {
                Vector3 position;
               
                position = new Vector3(x * 16, y * 13.5f, transform.position.z + 10);
               
                
                Instantiate(colorMap.prefab,position,Quaternion.identity,transform);
            }
        }
    }
	
}
