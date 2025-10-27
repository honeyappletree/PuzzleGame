using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuestManager : MonoBehaviour
{
    [SerializeField] private GameObject guest1;
    [SerializeField] private Text firstDialogue;
    int spaceDialogue = 0;
    int buttonDialogue = 0;
    int sum = 0;
    [SerializeField] Text dialogueText;
    [SerializeField][TextArea] string[] dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = " ";

        if (StageManager.clear1 == true)
        {
            guest1.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            StartCoroutine(SpaceNextDialogue());
        }
    }

    IEnumerator SpaceNextDialogue()
    {
        if (spaceDialogue < 3)
        {
            dialogueText.text = " ";
            string talk = dialogue[spaceDialogue];
            spaceDialogue++;
            sum += spaceDialogue;

            for (int j = 0; j < talk.Length; j++)
            {
                dialogueText.text += talk[j];
                yield return new WaitForSeconds(0.08f);
            }

            if (spaceDialogue == 2)
            {
                yield return new WaitForSeconds(0.5f);
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    }
