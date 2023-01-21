using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public float areaInit = 10f;
    public float forceIn = 9f;
    public Text loltext;
    public float a = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSize(float a){
        transform.localScale = new Vector3 (a/10, 5f, 1f);
    }
    public void Trolltext(){
        loltext.text = "Hmm this seems hard...";
    }
}
