using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    int lvl;
    // Start is called before the first frame update
    void Start()
    {
         int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
 if (SceneManager.sceneCount > nextSceneIndex)
 {
     SceneManager.LoadScene(nextSceneIndex);
 }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
       
        
        if (col.gameObject.tag == "Finish")
        {
            nextlevel();
        }
        else if (col.gameObject.tag == "zzzz")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }
    private void nextlevel()
    {
        lvl = SceneManager.GetActiveScene().buildIndex;
        
        Arasahne.level = lvl + 1;
        SceneManager.LoadScene("Arasahne");                                               
    }
}
