using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteSpawnSystem : MonoBehaviour
{
    public GameObject[] spawn;
    public GameObject currentSpawn;
    public int index;
    public float xMin, xMax, yMin, yMax, zPos;

    void Start()
    {
        StartCoroutine(SpawnRate());
    }

    void Update()
    {

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawSphere(new Vector3(xMin, yMin, zPos), 0f);
        Gizmos.DrawSphere(new Vector3(xMin, yMax, zPos), 0f);
        Gizmos.DrawSphere(new Vector3(xMax, yMin, zPos), 0f);
        Gizmos.DrawSphere(new Vector3(xMax, yMax, zPos), 0f);
    }

    void InfiniteSpawn()
    {
        PickNewIndex();
        float xPos = Random.Range(xMin, xMax);
        float yPos = Random.Range(yMin, yMax);

        Vector3 spawnPos = new Vector3(xPos, yPos, zPos);

        Instantiate(currentSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
    }

    void PickNewIndex()
    {
        index = Random.Range(0, spawn.Length);
        currentSpawn = spawn[index];

        //print(currentSpawn.name);
    }

    IEnumerator SpawnRate()
    {
        InfiniteSpawn();
        yield return new WaitForSeconds(0.125f);
        StartCoroutine(SpawnRate());
    }



}