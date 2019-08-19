using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject bir,iki,uj;

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bir.gameObject.transform.Rotate(0, 0, Time.deltaTime * speed*-15);
        iki.gameObject.transform.Rotate(0, 0, Time.deltaTime * speed*16);
        uj.gameObject.transform.Rotate(0, 0, Time.deltaTime * speed*-13);
        
    }
}
