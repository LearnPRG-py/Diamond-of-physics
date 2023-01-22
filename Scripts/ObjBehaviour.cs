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
        score+=1;
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
}
