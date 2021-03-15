using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    Image ImageTest;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = new GameObject();
        if (go != null)
        {
            
        }
        
        ImageTest = GameObject.Find("test").GetComponent<Image>();
    }
}
