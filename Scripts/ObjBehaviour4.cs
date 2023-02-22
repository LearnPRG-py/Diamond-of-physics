using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ObjBehaviour4 : MonoBehaviour
{
    public Text objdisttxt;
    public float focaldist = -1f;
    public float objectdist;
    public float imagedist;
    public float randomobjdist = 4f;
    public float reqimgdist = -1.3333f;
    public System.Random randomobj = new System.Random();
    public float score;
    public float tries;
    public Text triesTXT;
    public Text scoreTXT;
    public Text ReqImgDistTXT;
    public float scoreadd = 1f;
    public float hints = 0f;
    public int LBid = 11229;
    public Text hint1;
    public Text hint2;
    public Text hint3;
    public LineRenderer l;
    public float imght;
    public float imgdist;
    public bool click;
           
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveScene();
    }
    public void MoveObj(float a){
        transform.position = new Vector3 (a-9f,0.5f,0f);
        objdisttxt.text = "Object distance = "+(9f-a).ToString();
        objectdist = a;
        l.enabled = false;
    }

    public void ifCorrect(){
        randomobjdist = (float)(9f-randomobj.Next(0, 8));
        if(randomobjdist != 1){
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
        tries+=1;
        triesTXT.text = "Tries:"+tries.ToString();
        Debug.Log(objectdist);
        imgdist = (focaldist*(9f-objectdist))/(focaldist+(9f-objectdist));
        imght = imgdist/(9f-objectdist);
        List<Vector3> points1 = new List<Vector3>();
        List<Vector3> points2 = new List<Vector3>();
        if (objectdist != 8f){
        l.enabled = true;
        points1.Add(new Vector3(objectdist-9f, 1f, 0));
        points1.Add(new Vector3(0, 1f, 0));
        points1.Add(new Vector3(-1f*imgdist, imght, 0));
        points1.Add(new Vector3(objectdist-9f, 1f, 0));
        Debug.Log(objectdist);
        Debug.Log(imgdist);
        Debug.Log(imght);
        l.startWidth = 0.1f;
        l.endWidth = 0.1f;
        l.SetPositions(points1.ToArray());
        l.useWorldSpace = true;
       //Debug.Log(imght);
       click = false;
        }
        if (randomobjdist == 9f-objectdist){
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
    public void MoveScene(){
        if (score > 5f){
            SceneManager.LoadScene("End");
        }
    }
}
