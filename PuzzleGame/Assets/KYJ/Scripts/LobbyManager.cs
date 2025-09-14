using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    [SerializeField] Button undoButton;
    //[SerializeField] Button stage1Button;

    // Start is called before the first frame update
    void Start()
    {
        undoButton.onClick.AddListener(ClickUndo);
        //stage1Button.onClick.AddListener(GoStory1);
    }

    void ClickUndo() //UndoButton¿ª ¥≠∑∂¿ª ∂ß
    {
        SceneManager.LoadScene("SampleScene");
    }

    void GoStory1() //Stage1Button¿ª ¥≠∑∂¿ª ∂ß
    {
        SceneManager.LoadScene("Stage1");
    }
}
