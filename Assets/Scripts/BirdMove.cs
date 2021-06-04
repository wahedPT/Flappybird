using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BirdMove : MonoBehaviour
{
    Rigidbody2D Brb;
    public float Yup;
    Animator anim;

    RepeatB BackGround;
    RepeatB Ground;
    Spawn colspn;
   
    public GameObject Endscrn;
    AudioSource Birdfly;

    // Start is called before the first frame update
    void Start()
    {

        Brb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        BackGround = GameObject.Find("BackGround").GetComponent<RepeatB>();
        Ground = GameObject.Find("Ground").GetComponent<RepeatB>();
        colspn = GameObject.Find("Spawnmanager").GetComponent<Spawn>();
        Birdfly = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Brb.velocity = new Vector2(0, Yup);
            Birdfly.Play();

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Ground") 

        {

            anim.SetTrigger("Dead");//playing animation 
            BackGround.offset = 0;// background stop
            Ground.offset = 0;//ground stop
           Endscrn.gameObject.SetActive(true);//pop  over the gameover
            colspn.CancelInvoke("spawn");//cancel the spawning of columns
        }


        if (collision.gameObject.tag == "Column")
        {
            anim.SetTrigger("Dead"); 
            BackGround.offset = 0;
            Ground.offset = 0;
            Endscrn.gameObject.SetActive(true);
            colspn.CancelInvoke("spawn");
            Destroy(collision.gameObject);
        }

      if(collision.gameObject.tag=="ScoreZone")
      {
            ScoreScript.scoreValue += 1;
      }

    }

   


}


