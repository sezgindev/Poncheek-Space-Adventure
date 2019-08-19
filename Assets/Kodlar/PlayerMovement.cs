using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator pos,scale,camera,kafa, govde, arkakol, onkol, onayak, arkaayak,idle,kafaidle,arkakolidle,onkolidle,onayakidle,arkaayakidle,bit;
    public CharacterController2D controller;
    public float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool calis = false;
    bool calisol = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            calis = true;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            calis = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            calisol = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            calisol = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            jump = false;
        }
        if (calisol)
        {

            horizontalMove = -runSpeed;
            if (Input.GetButtonDown("Jump"))
            {

                jump = true;
            
        }

    }
        else if (calis)
        {
            //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            horizontalMove = runSpeed;
            if (Input.GetButtonDown("Jump"))
            {

                jump = true;
            }
        }
        else
            horizontalMove = 0f;
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,false,jump);
        jump = false;

    }
    public void Anim()      //Movement animation 
    {
        calis = true;       
        kafa.SetTrigger("kafa");            
        govde.SetTrigger("govde");
        arkakol.SetTrigger("arkakol");
        onayak.SetTrigger("onayak");
        onkol.SetTrigger("onkol");
        arkaayak.SetTrigger("arkaayak");
    }
    public void Birak()     //
    {
        calisol = false;        
        calis = false;
        idle.SetTrigger("idle");
        kafaidle.SetTrigger("kafaidle");
        arkakolidle.SetTrigger("arkakolidle");
        onkolidle.SetTrigger("onkolidle");
        onayakidle.SetTrigger("onayakidle");
        arkaayakidle.SetTrigger("arkaayakidle");


    }
    public void Animsol()
    {
        
        calisol = true;
        kafa.SetTrigger("kafa");
        govde.SetTrigger("govde");
        arkakol.SetTrigger("arkakol");
        onayak.SetTrigger("onayak");
        onkol.SetTrigger("onkol");
        arkaayak.SetTrigger("arkaayak");
    }
    public void Zip()
    {

        jump = true;

    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Finish")
        {
            bit.SetTrigger("biy");
            Invoke("KamAnim", 1);
            Debug.Log("2");
        }

      
    }
    void KamAnim()
    {
        camera.SetTrigger("campass");
    }

    public void level10uc()
    {
        transform.position = gameObject.transform.forward * Time.deltaTime;
    }
}
