using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level12SapanvurRixv2 : MonoBehaviour
{
    public GameObject duvar1, top1, uzayli1;
    public GameObject overpanel;
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
        if (col.gameObject.tag == "ufo4")
        {
            Destroy(duvar1);
            Destroy(top1);
            Destroy(uzayli1);
        }
        if (col.gameObject.tag == "ufo1")
        {
            Destroy(top1);
            overpanel.SetActive(true);
            if (Time.timeScale == 1)
                Time.timeScale = 0;
        }
    }
}
