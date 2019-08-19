using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSec : MonoBehaviour {
    int levelPassed;
    int level = 1;
    public Button[] butons;
    
	
	void Start () {

       // PlayerPrefs.DeleteAll();    

        //bu kodu apk almadan once bir kere calıstırıp save at ardından tekrar yorum satırına donustur.



        if (gameObject.name=="1")
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            if (PlayerPrefs.GetInt(gameObject.name) == 0)
            {
                GetComponent<Button>().interactable = false;

            }
            else
                GetComponent<Button>().interactable = true;


        }
        

    }

    



	void Update () {
       
    }


    public void LevelSecme(int levelAd)
    {

        SceneManager.LoadScene(levelAd);
        Time.timeScale = 1;
    }
    


}
