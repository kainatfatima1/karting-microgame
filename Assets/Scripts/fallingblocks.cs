using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingblocks : MonoBehaviour
{
    public Transform[] fallingpoints;
    public GameObject blockPrefab;

    private float timefornext = 2.0f;
    public float timefornextwave = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>= timefornext)
        {
            SpawnBlocks();
            timefornext = Time.time + timefornextwave;
        }
    }
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, fallingpoints.Length);

        for (int i = 0; i < fallingpoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, fallingpoints[i].position, Quaternion.identity);

            }
        }
    }
}
