using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    public void OnMouseDrag()   //Drag and Drop mouse and touch
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        transform.position = mousePos;

    }
}
