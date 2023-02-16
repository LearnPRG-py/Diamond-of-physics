using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public bool addtoscore = true;
    public float scoreadd=1f;
    public float hints =0f;

    public Text hint1;
    public Text hint2;
    public Text hint3;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        MoveScene();
        if (Input.GetKeyDown(KeyCode.R)){
            Reset();
            addtoscore = true;
        }
        if (Projectilecollider.IsTouching(Target)){
            if (addtoscore){
                IfTouch();
                addtoscore = false;
                }
            
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
        score+=scoreadd;
    }
    public void UpdateTXT(){
        scoretext.text = "Score: "+score.ToString();
        triestext.text = "Tries:"+tries.ToString();
        projpos.text = "("+transform.position.x+","+transform.position.y+")";
    }
    public void Hints(){
        hints+=1;
        if (hints == 1f){
            hint1.text = "The formula can be derived by assuming \n that the projectile hits target at max hight";
            scoreadd=1f;
        }
        if (hints == 2f){
            hint2.text = "velocity initial^2 = 2*horz displacement*\nvert displacement*sin^2(the angle of launch)";
            scoreadd=0.75f;
        }
        if (hints == 3f){
            hint3.text = "the angle of launch = tan inverse of \n (2*vert displacement/horz displacement)";
            scoreadd=0.5f;
        }

    }
    public void MoveScene(){
        if (score > 5f){
            SceneManager.LoadScene("SL3");
        }
    }
}
