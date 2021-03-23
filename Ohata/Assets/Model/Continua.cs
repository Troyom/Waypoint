using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continua : MonoBehaviour
{
    public Transform alvo;
    public List<Transform> alvoList = new List<Transform>();
    private int pontos = 0;
    bool voltando = false; 
    void Start()
    {
        alvo = alvoList[pontos];

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, alvo.position) > 0.2f)
            transform.position += (alvo.position - transform.position).normalized * 8f * Time.deltaTime;
        else
            ChangePatrolPoint();
    }
    void ChangePatrolPoint()
    {
        if (!voltando)
            pontos++;
        else
            pontos--;

        if (pontos >= alvoList.Count)
        {
            pontos = (alvoList.Count - 1);
            voltando = true;
        }
        else if (pontos < 0)
        {
            pontos = 0;
            voltando = false;
        }

        alvo = alvoList[pontos];
    }
}
