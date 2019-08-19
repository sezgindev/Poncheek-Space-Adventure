using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("q");
    }
    public void levels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void level1()
    {
        SceneManager.LoadScene("1");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level2()
    {
       SceneManager.LoadScene("2");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level3()
    {
        SceneManager.LoadScene("3");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level4()
    {
        SceneManager.LoadScene("Level4");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level5()
    {
        SceneManager.LoadScene("Level5");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level6()
    {
        SceneManager.LoadScene("Level6");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level7()
    {
        SceneManager.LoadScene("Level7");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level8()
    {
        SceneManager.LoadScene("Level8");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level9()
    {
        SceneManager.LoadScene("Level9");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level10()
    {
        SceneManager.LoadScene("Level10");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level11()
    {
        SceneManager.LoadScene("Level11");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void level12()
    {
        SceneManager.LoadScene("Level12");
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
}
