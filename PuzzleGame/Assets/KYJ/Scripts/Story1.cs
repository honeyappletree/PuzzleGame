using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{
    [SerializeField] Button nextButton;
    int nextDialogue = 0;
    [SerializeField] Text nameText;
    [SerializeField] Text dialogueText;
    [SerializeField] [TextArea] string[] dialogue;
    [SerializeField][TextArea] string[] name;

    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(NextDialogue);
        nameText.text = name[nextDialogue];
        dialogueText.text = dialogue[nextDialogue];
        //StartCoroutine(Dialogue());
    }

    void Update()
    {
        PressSpace();
    }

    void PressSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            nextDialogue++;
            nameText.text = name[nextDialogue];
            dialogueText.text = dialogue[nextDialogue];

            if (nextDialogue == 10)
            {
                StartGame.readDialogue1 = true;
                SceneManager.LoadScene("Stage1");
            }
        }
    }

    //IEnumerator Dialogue()
    //{
    //    nameText.text = null;
    //    dialogueText.text = null;

    //    for(int i = 0; i < name.Length; i++)
    //    {
    //        nameText.text += name[i];
    //        yield return new WaitForSeconds(1f);
    //    }

    //    for(int j = 0; j < dialogue.Length; j++)
    //    {
    //        dialogueText.text += dialogue[j];
    //        yield return new WaitForSeconds(1f);
    //    }
    //}

    void NextDialogue()
    {
        nextDialogue++;
        nameText.text = name[nextDialogue];
        dialogueText.text = dialogue[nextDialogue];

        if (nextDialogue == 10)
        {
            StartGame.readDialogue1 = true;
            SceneManager.LoadScene("Stage1");
        }
    }
}
