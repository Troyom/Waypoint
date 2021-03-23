using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uniforme : MonoBehaviour
{

    public Transform alvo;
    void Start()
    {
        
    }

    void Update()
    { 
        transform.position += (alvo.position - transform.position).normalized * 3f * Time.deltaTime;
    }
}
