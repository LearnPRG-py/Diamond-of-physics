using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Main : MonoBehaviour
{
    public float areaInit = 10f;
    public float forceIn = 9f;
    public float areasel;
    public Text loltext;
    public Text area;
    public Text FreqText;
    public System.Random randomforce = new System.Random();
    public float a = 1;
    public float forcereq = 23f;
    public float randomar;
    public float score;
    public float tries;
    public Text scoretxt;
    public Text triestxt;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "Score: " + score.ToString();
        triestxt.text = "Tries: " + tries.ToString();
    }
    public void SetSize(float a){
        transform.localScale = new Vector3 (a/10, 5f, 1f);
        area.text = "Area of right = "+a.ToString();

    }
    public void Trolltext(){
        loltext.text = "Hmm this seems hard...";
    }
    public void Correct(){
        randomar = (float)randomforce.Next(1,100);
        forcereq = randomar*0.9f;
        FreqText.text = "Force req = "+forcereq.ToString();
        score+=1;
        tries+=1;
    }
    public void Check(){
        if (forcereq == areasel*0.9){
            Correct();
        }
        else{
            tries+=1;
        }

    }
}
