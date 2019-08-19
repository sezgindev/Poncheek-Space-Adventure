using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{   private bool isPressed;
 
    private float releaseDelay;
    private float maxDragDistance = 2f;
    private Rigidbody2D rb;
    private SpringJoint2D sj;
    private Rigidbody2D slingRb;
    private LineRenderer lr;
    private TrailRenderer tr;
    void Update()
    {
        if (isPressed)
        {
            DragBall();
        }
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sj = GetComponent<SpringJoint2D>();
        slingRb = sj.connectedBody;
        releaseDelay = 1 / (sj.frequency * 4);
        lr = GetComponent<LineRenderer>();
        tr = GetComponent<TrailRenderer>();
        lr.enabled = false;
        tr.enabled = false;
    }
    private void DragBall()
    {
        SetLineRenderedPosition();
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(mousePosition, slingRb.position);
       

        if (distance > maxDragDistance)
        {
            Vector2 direction = (mousePosition - slingRb.position).normalized;
            rb.position = slingRb.position + direction * maxDragDistance;
        }
        else
        {
            rb.position = mousePosition;
        }
            

        } 
    private void SetLineRenderedPosition()
    {
        Vector3[] positions = new Vector3[2];
        positions[0] = rb.position;
        positions[1] = slingRb.position;
        lr.SetPositions(positions);

    }
    private IEnumerator Release ()
    {
        yield return new WaitForSeconds(releaseDelay);
        sj.enabled = false;
        tr.enabled = false;
    }
    private void OnMouseDown()
    { 
        isPressed = true;
        rb.isKinematic = true;
        lr.enabled = true;
    }
    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        lr.enabled = false;
    }
    
    
}
