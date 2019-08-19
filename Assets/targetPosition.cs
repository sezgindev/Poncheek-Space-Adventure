using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetPosition : MonoBehaviour
    
{
    public Rigidbody2D rb;
    public float donhiz = 5f;
    public GameObject hedef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = hedef.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.back);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, donhiz * Time.deltaTime);
    }
    public void ButBas()
    {

        rb.gravityScale = -5;


    }
    public void ButBirak()
    {
        rb.gravityScale = 3;
    }
}
