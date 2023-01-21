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
    public float score;
    public float tries;
    public Rigidbody2D projectile;
    public Collider2D Target;
    public Collider2D Projectilecollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            Reset();
        }
    }
    public void GetForce(string a){
        force = float.Parse(a);
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
                projectile.velocity = new Vector2 (force*Mathf.Cos(angle), force*Mathf.Sin(angle));
                tries+=1;
            }
        }
    }
    public void IfTouch(){
        Reset();
        score+=1;
    }
}
