using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator kucul;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
        
    // Update is called once per frame
    void Update()
    {

      
    }
    public void boom()
    {
      
    }
     private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            kucul.SetTrigger("lab");
            GameObject.Find("Player").GetComponent<CharacterController2D>().m_JumpForce = 850;
        }
    }
}
