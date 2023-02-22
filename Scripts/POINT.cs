using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POINT : MonoBehaviour
{
    public float ansX;
    public float ansY;
    public GameObject pt;
    // Start is called before the first frame update
    void Start()
    {
        pt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GETANSX(string a){
        ansX = float.Parse(a);
        pt.SetActive(false);
    }
    public void GETANSY(string b){
        ansY = float.Parse(b);
    }
    public void Oncheck(){
        transform.position = new Vector3(ansX, ansY, 0);
        pt.SetActive(true);
    }
}
