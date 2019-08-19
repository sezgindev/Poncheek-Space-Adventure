using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void durdur()
    {
        pause.SetActive(true);
        if(Time.timeScale==1)
            Time.timeScale = 0;

    }
    public void devaaam()
    {
        pause.SetActive(false);
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void anamen()
    {
        SceneManager.LoadScene("Menü");
    }
    public void restinpeace()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
}
