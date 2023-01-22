using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ObjBehaviour : MonoBehaviour
{
    public Text objdisttxt;
    public float focaldist = 1f;
    public float objectdist;
    public float imagedist;
    public float randomobjdist = -5f;
    public float reqimgdist = 1.25f;
    public System.Random randomobj = new System.Random();
    public float score;
    public float tries;
    public Text triesTXT;
    public Text scoreTXT;
    public Text ReqImgDistTXT;
    public float scoreadd = 1f;
    public float hints = 0f;
    
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
        
    }
    public void MoveObj(float a){
        transform.position = new Vector3 (a-9f,0.5f,0f);
        objdisttxt.text = "Object distance = "+(a-9f).ToString();
        objectdist = a;
    }
    public void FindImgDist(){
        imagedist = focaldist*objectdist/focaldist+objectdist;
    }
    public void ifCorrect(){
        randomobjdist = (float)(randomobj.Next(0, 8))-9f;
        if(randomobjdist != 0){
            reqimgdist = focaldist*randomobjdist/(focaldist+randomobjdist);
            ReqImgDistTXT.text = "Req Img Distance = "+reqimgdist.ToString();
        }
        else{
            ReqImgDistTXT.text = "Req Img Distance = Infinity";
        }    
        score+=scoreadd;
        scoreTXT.text = "Score:"+score.ToString();

    }
    public void Check(){
        FindImgDist();
        tries+=1;
        triesTXT.text = "Tries:"+tries.ToString();
        Debug.Log(objectdist);
        if (randomobjdist == objectdist-9f){
            ifCorrect();
        }
    }
        public void Hints(){
        hints+=1;
        if (hints == 1f){
            hint1.text = "The lensmakers formula is handy here";
            scoreadd=1f;
        }
        if (hints == 2f){
            hint2.text = "1/image distance+1/object distance = 1/focal length, careful with the signs!!";
            scoreadd=0.75f;
        }
        if (hints == 3f){
            hint3.text = "imagedist = focaldist*objectdist/focaldist+objectdist";
            scoreadd=0.5f;
        }

    }
}
