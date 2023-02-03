using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HStable : MonoBehaviour
{
    public Transform entryContainer;
    public Transform entryTemplate;
    private void awake(){
        entryTemplate.gameObject.SetActive(false);
        for (int i = 0; i < 10; i++){
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -20*i);
            entryTemplate.gameObject.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
