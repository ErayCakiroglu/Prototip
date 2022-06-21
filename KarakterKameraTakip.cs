using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKameraTakip : MonoBehaviour
{
    [SerializeField] GameObject hedef;
    [SerializeField] Vector3 mesafe;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, hedef.transform.position + mesafe, Time.deltaTime);
    }
}
