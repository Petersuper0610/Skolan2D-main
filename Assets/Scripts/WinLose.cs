using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class WinLose : MonoBehaviour
{
public TextManager textManager;
    public TMP_Text WinLoseText;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (textManager.score >= 100)
        { 
            Time.timeScale = 0;
            WinLoseText.gameObject.SetActive(true);
            WinLoseText.text = "You Win";
        } 
        else if(textManager.score < 0) 
        {
            Time.timeScale = 0;
            WinLoseText.gameObject.SetActive(true);
            WinLoseText.text = "You Lose";
        }
    }

    public void restrt()
    {
        SceneManager.LoadScene(0);
    }


}
