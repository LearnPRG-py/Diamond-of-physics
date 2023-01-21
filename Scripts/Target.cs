using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Target : MonoBehaviour
{
    public Text targetposition;
    public System.Random randposx = new System.Random();
    public System.Random randposy = new System.Random();
    public Collider2D Targetcol;
    public Collider2D Projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Targetcol.IsTouching(Projectile)){
        transform.position = new Vector3((float)randposx.NextDouble()*6f-1f, (float)randposy.NextDouble()*6f-1f,0);
        targetposition.text = "Position is: ("+(Mathf.Round(transform.position.x*100f)/100f).ToString()+","+(Mathf.Round(transform.position.y*100f)/100f).ToString()+")";
        }
    }
}
