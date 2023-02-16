using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public float areaInit = 10f;
    public float forceIn = 9f;
    public int areasel;
    public Text loltext;
    public Text area;
    public Text FreqText;
    public System.Random randomforce = new System.Random();
    public float a = 1;
    public float forcereq = 18f;
    public int randomar = 20;
    public float score;
    public float tries;
    public Text scoretxt;
    public Text triestxt;
    public bool click;
    public float scoreadd = 1f;
    public float hints = 0f;
    public float ltno = 0f;
    
    public Text hint1;
    public Text hint2;
    public Text hint3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveScene();
    }
    public void SetSize(string a){
        transform.localScale = new Vector3 (float.Parse(a)/10, 5f, 1f);
        area.text = "Area of right = "+a.ToString();
        areasel = (int)(float.Parse(a));
        }

    
    public void Trolltext(string a){
        if (ltno == 0){
            loltext.text = "Hmm this seems hard...";
            }
        if (ltno == 1){
            loltext.text = "I do not think this works...";
            }
        if (ltno == 2){
            loltext.text = "Yep this does not function...";
            }
        if (ltno == 3){
            loltext.text = "Im serious...";
            }
        if (ltno == 4){
            loltext.text = "whatever... keep trying...";
            }
        if (ltno == 5){
            loltext.text = "hmm how do we open the door?";
        }
        if (ltno == 6){
            loltext.text = "that contraption.. on the left...";
        }
        if (a == "Aryan"){
            loltext.text = "I recognize that name but no...";
        }
        ltno=ltno+1f;
    }
    public void Check(){
        if (randomar == areasel){
            randomar = randomforce.Next(1,100);
            forcereq = ((float)randomar)*0.9f;
            FreqText.text = "Force req = "+forcereq.ToString();
            score+=scoreadd;
            tries+=1;
            scoretxt.text = "Score: " + score.ToString();
            triestxt.text = "Tries: " + tries.ToString();
        }
        else{
            tries+=1;
            scoretxt.text = "Score: " + score.ToString();
            triestxt.text = "Tries: " + tries.ToString();
        }
    }
    public void Hints(){
        hints+=1;
        if (hints == 1f){
            hint1.text = "Pressure is equal to force by area";
            scoreadd=1f;
        }
        if (hints == 2f){
            hint2.text = "Pressure is transmitted equally throught an ideal fluid";
            scoreadd=0.75f;
        }
        if (hints == 3f){
            hint3.text = "Area on right = Force required/(force in/area left)";
            scoreadd=0.5f;
        }

    }
    public void MoveScene(){
        if (score > 3f){
            SceneManager.LoadScene("Lens");
        }
    }
}
