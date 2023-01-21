using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectile_motion : MonoBehaviour
{
    public float force;
    public float angle;
    public Text scoretext;
    public Text triestext;
    public Text projpos;
    public float score;
    public float tries;
    public Rigidbody2D projectile;
    public Collider2D Target;
    public Collider2D Projectilecollider;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            Reset();
        }
        if (Projectilecollider.IsTouching(Target)){
            IfTouch();
        }
        UpdateTXT();
    }
    public void GetForce(string a){
        force = float.Parse(a);
        if (force>20){
            force = 20;
        }
    }
    public void GetAngle(string b){
        angle = float.Parse(b);
    }
    void Reset(){
        projectile.gravityScale = 0;
        projectile.velocity = Vector2.zero;
        force = 0f;
        angle = 0f;
        transform.position = new Vector3 (-5f, -1.6f, 0f);
    }
    public void Launch(){
        if (force != null){
            if (angle != null){
                projectile.gravityScale = 1;
                projectile.velocity = new Vector2 (force*Mathf.Cos(angle*3.141592f/180), force*Mathf.Sin(angle*3.141592f/180));
                tries+=1;
            }
        }
    }
    public void IfTouch(){
        Reset();
        score+=1;
    }
    public void UpdateTXT(){
        scoretext.text = "Score: "+score.ToString();
        triestext.text = "Tries:"+tries.ToString();
        projpos.text = "("+transform.position.x+","+transform.position.y+")";
    }
}
