using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level11uzaylısaklan : MonoBehaviour
{
    public GameObject[] ufolar;
    
    GameObject ufo;

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
            Invoke("saklan", 1);
        }
    }
        public void saklan()
    {


        ufolar = GameObject.FindGameObjectsWithTag("ufo");

        foreach (GameObject ufo in ufolar)

        {

            ufo.SetActive(false);

            
        }
       
    }
}