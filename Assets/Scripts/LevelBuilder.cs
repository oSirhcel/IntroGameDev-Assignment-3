using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    public GameObject[] tiles;
    public int[,] levelMap =
        {
             {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
             {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
             {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
             {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
             {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
             {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
             {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
             {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
             {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
             {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
             {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
             {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
             {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
             {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
             {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };


    void Start()
    {
        GenerateLevel();
        CenterCamera();
    }

    void GenerateLevel()
    {
        for (int y = 0; y < levelMap.GetLength(1); y++)
        {
            for (int x = 0; x < levelMap.GetLength(0); x++)
            {
                int tileIndex = levelMap[x, y];
                if(tileIndex != 0)
                {
                    GameObject newTile = Instantiate(tiles[tileIndex - 1], new Vector3(x, y, 0), Quaternion.identity);
                    newTile.transform.SetParent(transform);

                }
            }
        }
    }

    void CenterCamera()
    {
        Camera.main.transform.position = new Vector3(levelMap.GetLength(0) / 2.0f, levelMap.GetLength(1) / 2.0f, -10);

        float aspectRatio = (float)Screen.width / (float)Screen.height;
        float verticalSize = levelMap.GetLength(1) / 2.0f + 1;
        float horizontalSize = (levelMap.GetLength(0) / 2.0f + 1) / aspectRatio;
        Camera.main.orthographicSize = Mathf.Max(verticalSize, horizontalSize);
    }

}