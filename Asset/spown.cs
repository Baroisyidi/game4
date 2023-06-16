using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spown : MonoBehaviour
{
    public GameObject block;
    public float spownRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnblock();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spownRate) {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnblock();
            timer = 0;
        }
        
    }
    void spawnblock()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset; 
        Instantiate(block, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
