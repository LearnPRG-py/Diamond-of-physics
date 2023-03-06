using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FNMA : MonoBehaviour
{
    public float velocity_needed = 15f;
    public Text vel_needed_TXT;
    public Text ScoreTXT;
    public Text TriesTXT;
    public Text CurrentVELTXT;
    public float mass = 2f;
    public float Force_entered;
    public System.Random randvel_needed = new System.Random();
    public float Score;
    public float Tries;
    public float hints;
    public Text hint1;
    public Text hint2;
    public Text hint3;
    public float scoreadd = 1f;
    public Rigidbody2D obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("r")){
            transform.position = new Vector3(-8f, -3.5f, 0f);
            obj.velocity = Vector2.zero;
        }
    }
    public void Correct(){
        velocity_needed = (((float)((randvel_needed.Next(1, 100)))/10)+10f);
        vel_needed_TXT.text = "Velocity needed: "+velocity_needed+"m/s";
        Score +=scoreadd;
        ScoreTXT.text = "Score: "+Score.ToString();
        SwitchScene();
    }
    public void Check(){
        Tries +=1f;
        TriesTXT.text = "Tries: " + Tries.ToString();
        CurrentVELTXT.text = "V after T: "+(Force_entered*1.2f/mass+10f) + "m/s";
        obj.AddForce(transform.right*Force_entered*80f);
        if ((System.Math.Abs((velocity_needed-10f)*mass/1.2f - Force_entered))< 0.1f){
            Correct();
        } 
    }
    public void GetForce(string a){
        Force_entered = float.Parse(a);
        CurrentVELTXT.text = "";
    }
     public void Hints(){
        hints+=1;
        if (hints == 1f){
            hint1.text = "The person who had an apple fall on his head knows.";
            scoreadd=1f;
        }
        if (hints == 2f){
            hint2.text = "Newton's Second law is essential to solve this!";
            scoreadd=0.75f;
        }
        if (hints == 3f){
            hint3.text = "Force is equal to rate of change (F=M*ΔV/ΔT)";
            scoreadd=0.5f;
        }
    }
    void SwitchScene(){
    if (Score > 5f){
        SceneManager.LoadScene("End");=
    }
}
}