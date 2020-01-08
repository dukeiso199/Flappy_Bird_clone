using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnPool : MonoBehaviour
{
    private GameObject[] columns;
    private int poolsize = 5;
    public GameObject prefab;
    private Vector2 objectPoolPosition = new Vector2 (-15f, 15f);
    /* array of columns
     * the prefab of the column 
     * the place where unused prefabs are
     */
    public float spawnrate = 4f;
    private float timeSinceSpawn;
    public float columnMiny = -1f;
    public float columnMaxy = 4f;
    private float xSpawnPosition = 10f;
    private int currentcolumn = 0;

    void Start()
    {
        columns = new GameObject[poolsize];
        for (int i = 0; i < poolsize; i ++)
        {
            columns[i] = (GameObject)Instantiate(prefab, objectPoolPosition, Quaternion.identity);
        }
        // intialize the columns and place them in a place far from the game to be used from there with out destroying
    }

    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        // if the game is not over and the time to spawn is here
        if (gamecontroller.instance.gameover == false && timeSinceSpawn>= spawnrate)
        {
            timeSinceSpawn = 0;
            float ySpawnPosition = Random.Range(columnMiny, columnMaxy);
            columns[currentcolumn].transform.position = new Vector2(xSpawnPosition, ySpawnPosition);
            currentcolumn++;
            if (currentcolumn >= poolsize)
            {
                currentcolumn = 0;
            }
        }
    }
}
