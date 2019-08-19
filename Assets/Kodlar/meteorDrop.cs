using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorDrop : MonoBehaviour
{
    public GameObject meteor;
    public float timer1,timer2,timer3,timer4,timer5 = 0;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(30.64f, 7);
        Vector2 pos2 = new Vector2(32.71f, 7);
        Vector2 pos3 = new Vector2(34.78f, 7);
        Vector2 pos4 = new Vector2(36.85f, 7);
        Vector2 pos5 = new Vector2(38.92f, 7);
        timer1 += Time.deltaTime;
        if (timer1 > 0.8f)
        {
            Instantiate(meteor, pos, Quaternion.identity);
            timer1 = 0;
        }

        timer2 += Time.deltaTime;
        if (timer2 > 0.9f)
        {
             Instantiate(meteor, pos2, Quaternion.identity);
            timer2 = 0;
        }
        timer3 += Time.deltaTime;
        if (timer3 > 1.2f)
        {
              Instantiate(meteor, pos3, Quaternion.identity);
            timer3 = 0;
        }
        timer4 += Time.deltaTime;
        if (timer4 > 1.4f)
        {
             Instantiate(meteor, pos4, Quaternion.identity);
            timer4 = 0;
        }
        timer5 += Time.deltaTime;
        if (timer5 > 1.5f)
        {
              Instantiate(meteor, pos5, Quaternion.identity);
            timer5 = 0;
        }

    }
        



}
  

