using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level12sapanvurRix : MonoBehaviour
{
    public GameObject duvar, top, uzayli,overpanel1;
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
        if (col.gameObject.tag == "zzzz")
        {
            Destroy(duvar);
            Destroy(top);
            Destroy(uzayli);
        }
        if (col.gameObject.tag == "ufo")
        {
            Destroy(top);
            overpanel1.SetActive(true);
            if (Time.timeScale == 1)
                Time.timeScale = 0;
        }
    }
}
