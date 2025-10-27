using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle5 : MonoBehaviour
{
    [SerializeField] private Image puzzle5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Jamjar"))
        {
            Debug.Log("범위 안에 머무르고 있습니다.");
            StageManager.correctPosition++;
            puzzle5.rectTransform.sizeDelta = new Vector2(380, 390);
            Debug.Log("correctionPosition: " + StageManager.correctPosition);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Jamjar"))
        {
            Debug.Log("범위를 벗어났습니다.");
            StageManager.correctPosition--;
            puzzle5.rectTransform.sizeDelta = new Vector2(190, 195);
            Debug.Log("correctionPosition: " + StageManager.correctPosition);
        }
    }
}
