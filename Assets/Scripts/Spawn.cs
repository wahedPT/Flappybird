using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject column;
   
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2.0f, 5.0f);

    }

    void spawn()
    {

        float xpos = Random.Range(11, 0);
        GameObject columnPrefab = Instantiate(column);
    }
    // Update is called once per frame
    void Update()
    {

       
    }
   
}
