using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSize(string a){
        transform.localScale = new Vector3 (float.Parse(a)/10, 5f, 1f);
        area.text = "Area of right = "+a.ToString();
        areasel = (int)(float.Parse(a));
        if (click){
            if (randomar == areasel){
            randomar = randomforce.Next(1,100);
            forcereq = ((float)randomar)*0.9f;
            FreqText.text = "Force req = "+forcereq.ToString();
            score+=1;
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

    }
    public void Trolltext(){
        loltext.text = "Hmm this seems hard...";
    }
    public void Check(){
        click = true;
    }
}
