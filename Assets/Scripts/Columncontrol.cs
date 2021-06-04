using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Columncontrol : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed;
    
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (transform.position.x < -21)
        {
            Destroy(this);
        }
    }
    
   

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

   
    
}
