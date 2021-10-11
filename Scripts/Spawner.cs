using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instanse;

    [SerializeField] GameObject groundPrefab;
    private float groundYDistance = 3.5f;
    private float curentYpos = 0f;

    [SerializeField] GameObject[] dogs;
    private float xPos = 2.25f;


    [SerializeField] GameObject diamond;
    private void Awake()
    {
        if (instanse == null)
        {
            instanse = this;
        }
    }
    void Start()
    {
        Spawn();
    }

    
    public void SpawnMoreGrounds()
    {
        curentYpos += groundYDistance;
        Vector3 newPos = new Vector3(0f, curentYpos, 0f);
        GameObject newGround = Instantiate(groundPrefab, newPos, Quaternion.identity);

        int randomDogs = Random.Range(0, 10);
        Vector3 dogPos = new Vector3(Random.Range(-xPos, xPos), newGround.transform.position.y + 0.3f);
        if (randomDogs >5)
        {
            GameObject obst = Instantiate(dogs[Random.Range(0, dogs.Length)], dogPos, Quaternion.identity);
        }

        int RandomDiamond = Random.Range(0,10);
        Vector3 diamondPos = new Vector3(Random.Range(-xPos, xPos), newGround.transform.position.y + 1.8f);
        if (RandomDiamond > 6)
        {
            GameObject diam = Instantiate(diamond, diamondPos, Quaternion.identity);
        }
    }
    public void Spawn()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnMoreGrounds();
        }
    }
}
