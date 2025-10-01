using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{
    [SerializeField] Button nextButton;
    int spaceDialogue = 0;
    int buttonDialogue = 0;
    int sum = 0;
    [SerializeField] Text nameText;
    [SerializeField] Text dialogueText;
    [SerializeField] [TextArea] string[] dialogue;
    [SerializeField][TextArea] string[] name;

    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(NextDialogue);
        nameText.text = " ";
        dialogueText.text = " ";
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            StartCoroutine(SpaceNextDialogue());
        }
    }

    IEnumerator SpaceNextDialogue()
    {
        //sum = spaceDialogue + buttonDialogue;
        if(spaceDialogue < 11)
        {
            dialogueText.text = " ";
            string talk = dialogue[spaceDialogue];
            nameText.text = name[spaceDialogue];
            spaceDialogue++;
            sum += spaceDialogue;

            for (int j = 0; j < talk.Length; j++)
            {
                dialogueText.text += talk[j];
                yield return new WaitForSeconds(0.08f);
            }

            if (spaceDialogue == 11)
            {
                yield return new WaitForSeconds(0.5f);
                SceneManager.LoadScene("GuestScene");
            }
        }
    }

    IEnumerator ButtonNextDialogue()
    {
        if (buttonDialogue < 11)
        {
            dialogueText.text = " ";
            string talk = dialogue[buttonDialogue];
            nameText.text = name[buttonDialogue];
            buttonDialogue++;
            sum += buttonDialogue;

            for (int j = 0; j < talk.Length; j++)
            {
                dialogueText.text += talk[j];
                yield return new WaitForSeconds(0.08f);
            }

            if (buttonDialogue == 11)
            {
                yield return new WaitForSeconds(0.5f);
                SceneManager.LoadScene("GuestScene");
            }
        }
        
    }

    void NextDialogue()
    {
        StartCoroutine(ButtonNextDialogue());
    }

}
