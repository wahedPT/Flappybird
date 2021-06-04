using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatB : MonoBehaviour
{
    public float offset;
    Material mat;
    
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset = new Vector2(offset * Time.time, 0);
    }
}
