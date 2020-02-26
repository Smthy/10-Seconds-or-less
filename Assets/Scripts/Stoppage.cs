using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stoppage : MonoBehaviour
{

    public MonoBehaviour InfiniteSpawner;

    private void Awake()
    {
        StartCoroutine(stop());
    }


    IEnumerator stop()
    {
        yield return new WaitForSeconds(9f);
        Destroy(InfiniteSpawner);
    }



   

}
