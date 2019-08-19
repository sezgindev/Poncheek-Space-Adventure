using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour
{

    public GameObject gameover;

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
        if (col.gameObject.tag == "gameover")
        {
            gameover.SetActive(true);
            if (Time.timeScale == 1)
                Time.timeScale = 0;

        }
    }
   
}
