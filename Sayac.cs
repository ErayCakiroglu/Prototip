using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Sayac : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI zamanSayaciText;
    [SerializeField] TextMeshProUGUI paraSayaciText;
    float zamanSayaci = 20;
    void Start()
    {
        
    }

    
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        zamanSayaciText.text = "" + (int)zamanSayaci;
        paraSayaciText.text = "" + Toplayici.toplananPara;
        if(zamanSayaci <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
