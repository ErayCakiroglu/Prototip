using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    [SerializeField] GameObject nesne;
    public static float karakterHiz = 1.5f;

    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * karakterHiz * Time.deltaTime;
        float dikeyEksen = Input.GetAxis("Vertical") * karakterHiz * Time.deltaTime;
        transform.Translate(yatayEksen * karakterHiz, 0f, dikeyEksen * karakterHiz);
    }

    void OnTriggerEnter(Collider temas)
    {
        if(temas.gameObject.tag == "UpgradeNoktasi")
        {
            if(Toplayici.toplananPara > 5)
            {
                nesne.SetActive(true);
            }
        }
    }
    

    void OnTriggerExit(Collider temas)
    {
        if(temas.gameObject.tag == "UpgradeNoktasi")
        {
            nesne.SetActive(false);
        }
    }

    public void ButonTiklama()
    {
        if(Toplayici.toplananPara >= 5)
        {
            Toplayici.toplananPara -= 5;
            karakterHiz += 0.25f;
        }
    }
}
