using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerScript : MonoBehaviour
{
    public int spawnFlag;
    public GameObject BasicCube;

    public int spawnFlagHeart;
    public GameObject HeartCube;

    public int spawnFlagDown;
    public GameObject DownCube;
    private GameObject[] gameObjects;

    public int numBasicSpawned;
    public int spawnFlagTrap;
    public GameObject TrapCube;

    public int numDownSpawned;
    public int spawnFlagExplosion;
    public GameObject ExplosionCube;


    void Start()
    {
        spawnFlag = 0;
        numBasicSpawned = 0;
        numDownSpawned = 0;
    }

    private void Update()
    {
        if (spawnFlag > 0)
        {
            destroyAllCube(0);
            spawnFlag = 0;
            GameObject clone;
            clone = Instantiate(BasicCube, transform.position, transform.rotation);
            numBasicSpawned++;
            numDownSpawned = 0;
        }
        else if (spawnFlagHeart > 0) {
            destroyAllCube(1);
            spawnFlagHeart = 0;
            GameObject clone;
            clone = Instantiate(HeartCube, transform.position, transform.rotation);
            numBasicSpawned = 0;
            numDownSpawned = 0;
        }
        else if (spawnFlagDown > 0)
        {
            destroyAllCube(2);
            spawnFlagDown = 0;
            GameObject clone;
            clone = Instantiate(DownCube, transform.position, transform.rotation);
            numBasicSpawned = 0;
            numDownSpawned++;
        }
        // Combo Explosion Cube
        if (numDownSpawned >= 6)
        {
            destroyAllCube(4);
            numDownSpawned = 0;
            GameObject clone;
            clone = Instantiate(ExplosionCube, transform.position, transform.rotation);
            
        }
        // Combo Trap Cube
        if (numBasicSpawned >= 6) {
            destroyAllCube(3);
            numBasicSpawned = 0;
            GameObject clone;
            clone = Instantiate(TrapCube, transform.position, transform.rotation);
        }
        

    }

    void destroyAllCube(int g) {
        if (g == 0)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("Cube");
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }

        } else if (g == 1)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("HeartCube");
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }

        } else if (g == 2)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("DownCube");
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }

        }
        else if (g == 3)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("TrapCube");
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }

        }
        else if (g == 4)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("ExplodingCube");
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }

        }
    }
}