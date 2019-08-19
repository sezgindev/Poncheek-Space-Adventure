using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Arasahne : MonoBehaviour
{
    public Text txt;
    public Text txteksibir;
    public int leveleksibir;
    public static int level = 1;

    IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(level);
    }


    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.DeleteAll();
        //buikldden once calsıtır
    }

    // Update is called once per frame
    void Update()
    {
        leveleksibir = level - 1;
        int sonrakiLevel = level;
        PlayerPrefs.SetInt(sonrakiLevel.ToString(), 1);
        string seconds = (level).ToString("f0");
        txt.text = seconds;
        string ac = (leveleksibir).ToString("f0");
        txteksibir.text = ac;

        StartCoroutine(WaitForSceneLoad());

    }
}
