using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Puzzle1 : MonoBehaviour
{
    [SerializeField] private Image puzzle1;

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
        if(other.gameObject.CompareTag("Candle"))
        {
            Debug.Log("범위 안에 머무르고 있습니다.");
            StageManager.correctPosition++;
            puzzle1.rectTransform.sizeDelta = new Vector2(600, 650);
            Debug.Log("correctionPosition: " + StageManager.correctPosition);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Candle"))
        {
            Debug.Log("범위를 벗어났습니다.");
            StageManager.correctPosition--;
            puzzle1.rectTransform.sizeDelta = new Vector2(300, 300);
            Debug.Log("correctionPosition: " + StageManager.correctPosition);
        }
    }
}
