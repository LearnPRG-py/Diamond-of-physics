using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class CTRLht : MonoBehaviour
{
    public float Scale = 1f;
    public Text ScaleTXT;
    public GameObject ramp;
    public float speed;
    public System.Random rndht;
    public Rigidbody2D objRB;
    public System.Random rndSCL = new System.Random();
    public float randomscale = 5.0f;
    public float reqSpeed = 31f;
    public float score;
    public float tries;
    public Text Scoretxt;
    public Text Triestxt;
    public Text SpeedOMatic;
    public Text ReqSpeedTXT;
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
            check();
        }
        if (transform.position.y < -5f){
            Physics2D.gravity = Vector2.zero;
            objRB.velocity = Vector2.zero;
            objRB.angularVelocity = 0f;
            transform.position = new Vector3(-8, (1f*(Scale-10f)+4.1f), 0f);
        }
    }
    public void GetScale(float a){
        Scale = a/10;
        ramp.transform.localScale = new Vector3(1.7f*Scale, Scale,0f);
        ramp.transform.position = new Vector3(-8.86f, (-1.5f*(10f/Scale)), 0f);
        transform.position = new Vector3(-8, (1f*(Scale-10f)+4.1f), 0f);
        ScaleTXT.text = "Height: "+(Scale*10f).ToString();
        Physics2D.gravity = Vector2.zero;
        objRB.velocity = Vector2.zero;
        objRB.angularVelocity = 0f;
    }
    public void GetSpeed(){
        speed = (float)System.Math.Sqrt(20.0f*9.81f*Scale);
        SpeedOMatic.text = "Speed: " + speed.ToString();
    }
    public void Correct(){
        randomscale = ((float)(rndSCL.Next(50, 100))/10f);
        reqSpeed = (float)System.Math.Sqrt(20.0f*9.81f*randomscale);
        ReqSpeedTXT.text = "Required Speed: " + reqSpeed.ToString();
        SwitchScene();
    }
    public void check(){
        GetSpeed();
        tries+=1f;
        if (Mathf.Round(speed) == Mathf.Round(reqSpeed)){
            Correct();
            score+=1f;
        }
        Scoretxt.text = "Score: " + score.ToString();
        Triestxt.text = "Tries: " + tries.ToString();
    }
    public void Release(){
        Physics2D.gravity = new Vector2(0, -9.8f);
    }
    void SwitchScene(){
    if (score > 7f){
        SceneManager.LoadScene("Forces and motion 1");
    }
}
}