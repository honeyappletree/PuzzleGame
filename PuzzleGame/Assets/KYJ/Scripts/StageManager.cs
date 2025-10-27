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
    [SerializeField] Button questionMarkButton1;
    [SerializeField] Button questionMarkButton2;
    [SerializeField] Button xButton;
    [SerializeField] GameObject tutorialPanel;
    [SerializeField] GameObject tutorialDialogue; //튜토리얼 지시 말풍선
    [SerializeField] Button dialogueQuitBtn; //튜토리얼 지시 말풍선 속 버튼
    bool startFirst = true;
    [SerializeField] GameObject maskImage;
    public static int correctPosition = 0; //정확한 위치에 퍼즐이 들어갔는지 확인하는 변수
    [SerializeField] GameObject clearText;
    public static bool clear1 = false;

    // Start is called before the first frame update
    void Start()
    {
        refreshButton.onClick.AddListener(Refresh);
        undoButton.onClick.AddListener(Undo);
        questionMarkButton1.onClick.AddListener(Questionmark);
        questionMarkButton2.onClick.AddListener(Tutorial);
        xButton.onClick.AddListener(Close);
        dialogueQuitBtn.onClick.AddListener(DialogueQuit);

        if (startFirst == true)
        {
            maskImage.SetActive(true);
            tutorialDialogue.SetActive(true);
        }

        Debug.Log(correctPosition);
    }

    private void Update()
    {
        if (correctPosition == 6)
        {
            Debug.Log("스테이지1을 클리어하였습니다.");
            clearText.SetActive(true);
            clear1 = true;
            Invoke("NextStage", 3f);
        }
    }

    void Refresh() //새로고침 버튼을 눌렀을 때
    {
        SceneManager.LoadScene("Stage1");
    }

    void Undo() //돌아가기 버튼을 눌렀을 때
    {
        SceneManager.LoadScene("GuestScene");
    }

    void Questionmark() //물음표 버튼을 눌렀을 때
    {
        tutorialPanel.SetActive(true);
    }

    void Close() //튜토리얼 창을 닫고자 할 때
    {
        tutorialPanel.SetActive(false);
    }

    void DialogueQuit()
    {
        tutorialDialogue.SetActive(false);
    }

    void Tutorial()
    {
        startFirst = false;
        tutorialPanel.SetActive(true);
        maskImage.SetActive(false);
        questionMarkButton2.gameObject.SetActive(false);
    }

    void NextStage()
    {
        SceneManager.LoadScene("GuestScene");
    }

}
