using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MoveObj(float a){
        transform.position = new Vector3 (a-9f,0.5f,0f);
    }
}
