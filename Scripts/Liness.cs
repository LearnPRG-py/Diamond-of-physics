using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Liness : MonoBehaviour
{
public System.Random pointxr = new System.Random();
public System.Random pointyr = new System.Random();
public System.Random m1r = new System.Random();
public System.Random m2r = new System.Random();
public int pointx, pointy, M1, M2;
public Text EQN1;
public Text EQN2;
public int ansX;
public int ansY;
public Text scoreTXT;
public Text triesTXT;
public float score;
public float tries;
public LineRenderer LR1;
public LineRenderer LR2;
public GameObject yayudidit;


public float scoreadd=1f;
public float hints =0f;

public Text hint1;
public Text hint2;
public Text hint3;
void Start()
{
	pointx = 2;
	pointy = 3;
	M1 = 2;
	M2 = 1;
    updatetxt();
}
void Update(){
    updatetxt();
}
public void updatetxt()
{
	EQN1.text = "y = "+ M1.ToString() +"x + ("+(pointy-M1*pointx).ToString()+")";
	EQN2.text = "y = "+M2.ToString()+"x + ("+(pointy-M2*pointx).ToString()+")";
    scoreTXT.text = "Score: "+score.ToString();
    triesTXT.text = "Tries: "+tries.ToString();
}
public void getansX(string a){
ansX = int.Parse(a);
LR1.enabled = false;
LR2.enabled = false;
yayudidit.SetActive(false);
}
public void getansY(string b){
ansY = int.Parse(b);
LR1.enabled = false;
LR2.enabled = false;
yayudidit.SetActive(false);
}

public void checkans(){
List<Vector3> points1 = new List<Vector3>();
List<Vector3> points2 = new List<Vector3>();
LR1.enabled = true;
LR2.enabled = true;
points1.Add(new Vector3(-8f, (((float)M1)*(-8f))+(float)(pointy-M1*pointx), 0));
points1.Add(new Vector3(8f, (((float)M1)*(8f))+(float)(pointy-M1*pointx), 0));
points2.Add(new Vector3(-8f, (((float)M2)*(-8f))+(float)(pointy-M2*pointx), 0));
points2.Add(new Vector3(8f, (((float)M2)*(8f))+(float)(pointy-M2*pointx), 0));
LR1.startWidth = 0.1f;
LR1.endWidth = 0.1f;
LR1.SetPositions(points1.ToArray());
LR1.useWorldSpace = true;
LR1.SetColors(Color.red, Color.red);
LR2.startWidth = 0.05f;
LR2.endWidth = 0.05f;
LR2.SetPositions(points2.ToArray());
LR2.useWorldSpace = true;
LR2.SetColors(Color.blue, Color.blue);
if (ansX == pointx){
	if (ansY == pointy){
    
	score+=scoreadd;
    yayudidit.SetActive(true);
    updateReq();
}
}
tries+=1;
SwitchScene();
}
public void updateReq(){
    pointx = pointxr.Next(-7, 7);
    pointy = pointxr.Next(-4, 4);
    M1 = m1r.Next(-10, 10);
    M2 = m2r.Next(-10, 10);
}
public void Hints(){
    hints+=1;
    if (hints == 1f){
        hint1.text = "To find the point of intersection of 2 lines \n you must solve both equations";
        scoreadd=1f;
    }
    if (hints == 2f){
        hint2.text = "The left hand sides are both equal to y and\n hence equal to each other.";
        scoreadd=0.75f;
    }
    if (hints == 3f){
        hint3.text = "Use the equation from hint 2 to solve for x\nuse any of the equations to get y";
        scoreadd=0.5f;
    }

    }
void SwitchScene(){
    if (score > 7f){
        SceneManager.LoadScene("Econs");
    }
}
}
