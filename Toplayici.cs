using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Toplayici : MonoBehaviour
{
    public static int toplananPara;
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider temas)
    {
        if(temas.tag == "Para")
        {
            temas.gameObject.transform.parent = transform;
        }
    }
}
