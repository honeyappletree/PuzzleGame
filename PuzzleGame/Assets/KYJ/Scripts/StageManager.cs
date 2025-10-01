using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StageManager : MonoBehaviour
{
    [SerializeField] Button refreshButton;
    [SerializeField] Button undoButton;

    // Start is called before the first frame update
    void Start()
    {
        refreshButton.onClick.AddListener(Refresh);
        undoButton.onClick.AddListener(Undo);
    }

    void Refresh() //새로고침 버튼을 눌렀을 때
    {
        SceneManager.LoadScene("Stage1");
    }

    void Undo() //돌아가기 버튼을 눌렀을 때
    {
        SceneManager.LoadScene("GuestScene");
    }
}
