using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CTRLht : MonoBehaviour
{
    public float Scale = 1f;
    public Text ScaleTXT;
    public GameObject ramp;
    public float speed;
    public System.Random rndht;
    public Rigidbody2D objRB;
    
    // Start is called before the first frame update
    void Start()
    {
          Physics2D.gravity = new Vector2(0, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")){
            Release();
        }
    }
    public void GetScale(float a){
        objRB.velocity = new Vector2(0f, 0f);
        Scale = a/10;
        ramp.transform.localScale = new Vector3(1.7f*Scale, Scale,0f);
        ramp.transform.position = new Vector3(-8.86f, (-1.5f*(10f/Scale)), 0f);
        transform.position = new Vector3(-8, (1f*(Scale-10f)+4.1f), 0f);
        ScaleTXT.text = "Height: "+(Scale).ToString();
    }
    public void GetSpeed(){
        speed = (float)System.Math.Sqrt(20.0f*9.81f*Scale);
    }
    public void Correct(){

    }
    public void check(){

    }
    public void Release(){
        Physics2D.gravity = new Vector2(0, -9.8f);
    }
}
