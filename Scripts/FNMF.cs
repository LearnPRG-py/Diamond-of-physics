using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FNMF : MonoBehaviour
{
    public float accn_needed = 5f;
    public Text accn_needed_TXT;
    public Text ScoreTXT;
    public Text TriesTXT;
    public Text CurrentACCNTXT;
    public float mass = 2f;
    public float Force_entered;
    public System.Random randaccn_needed = new System.Random();
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
        accn_needed = ((float)((randaccn_needed.Next(1, 100)))/10);
        accn_needed_TXT.text = "Acceleration needed: " + accn_needed + "m/s^2";
        Score +=scoreadd;
        ScoreTXT.text = "Score: "+Score.ToString();
    }
    public void Check(){
        Tries +=1f;
        TriesTXT.text = "Tries: " + Tries.ToString();
        CurrentACCNTXT.text = "Current acceleration: "+Force_entered/mass + "m/s^2";
        obj.AddForce(transform.right*Force_entered*80f);
        if (accn_needed*mass == Force_entered){
            Correct();
        } 
    }
    public void GetForce(string a){
        Force_entered = float.Parse(a);
        CurrentACCNTXT.text = "";
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
            hint3.text = "Force is equal to mass times acceleration (F=MA)";
            scoreadd=0.5f;
        }
    }
}
