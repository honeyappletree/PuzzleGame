using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button quitButton;
    [SerializeField] Button endButton;
    [SerializeField] GameObject quitPanel;
    [SerializeField] Button continueButton;
    public static bool readDialogue1 = false;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(GameStart);
        quitButton.onClick.AddListener(ClickQuit);
        endButton.onClick.AddListener(ClickEnd);
        continueButton.onClick.AddListener(ClickContinue);
    }

    void GameStart() //StartButtonÀ» ´­·¶À» ¶§
    {
        if(readDialogue1 == false)
        {
            SceneManager.LoadScene("Story1");
        }
        else 
        {
            SceneManager.LoadScene("Stage1");
        }
    }

    void ClickQuit() // QuitButtonÀ» ´­·¶À» ¶§
    {
        quitPanel.SetActive(true);
    }

    void ClickEnd() //EndButtonÀ» ´­·¶À» ¶§
    {
        quitPanel.SetActive(false);
        Application.Quit();
    }

    void ClickContinue() //ContinueButtonÀ» ´­·¶À» ¶§
    {
        quitPanel.SetActive(false);
    }
}
