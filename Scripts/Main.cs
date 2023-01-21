using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public void areaInit = 1;
    public void forceIn = 9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSize(float a){
        transform.localScale = (a/10, 5, 1);
    }
}
