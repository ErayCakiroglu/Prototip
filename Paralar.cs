using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Paralar : MonoBehaviour
{
    [SerializeField] GameObject para, spawnNoktasi;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider temas)
    {
        if(temas.tag == "Kasa")
        {
            transform.parent = null;
            transform.position = gameObject.transform.position;
            Toplayici.toplananPara++;
            Destroy(gameObject);
            ParayiGeriGonderme();
        }
    }

    void ParayiGeriGonderme()
    {
        GameObject yeniPara = Instantiate(gameObject, spawnNoktasi.transform.position, Quaternion.identity);
    }
}
