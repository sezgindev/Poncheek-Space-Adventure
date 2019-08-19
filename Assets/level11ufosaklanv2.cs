using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level11ufosaklanv2 : MonoBehaviour
{
    GameObject ufo1;
    public GameObject[] ufolar2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("saklancık", 1);
        }
    }
    public void saklancık() { 
        ufolar2 = GameObject.FindGameObjectsWithTag("ufo1");

        foreach (GameObject ufo1 in ufolar2)

        {

            ufo1.SetActive(false);
        }

    }
}

