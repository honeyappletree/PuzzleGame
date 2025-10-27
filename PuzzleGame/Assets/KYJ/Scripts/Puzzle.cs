using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class Puzzle : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Image puzzle; //퍼즐 조각 오브젝트
    Vector2 originPosition; //퍼즐 조각의 원래 위치
    bool pressSpace = false;
    bool selectPuzzle = false;

    // Start is called before the first frame update
    void Start()
    {
        originPosition = transform.position;
    }

    void Update()
    {
        if(selectPuzzle == true)
        {
            if (pressSpace == false)
            {
                pressSpace = true;
                Debug.Log("pressSpace: " + pressSpace);
            }
            else if (pressSpace == true)
            {
                pressSpace = false;
                Debug.Log("현재 상태는: " + pressSpace);
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData) //오브젝트를 클릭했을 때?
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (eventData.clickCount == 2)
            {
                puzzle.transform.Rotate(0, 0, 90); //z축 기준으로 마우스 오른쪽 버튼을 누를 때마다 90도씩 회전
                Debug.Log("더블클릭하였습니다.");
            }
        }
    }

    public void OnDrag(PointerEventData eventData) //오브젝트를 끌고 있는 중일 때
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            puzzle.transform.position = eventData.position;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            selectPuzzle = true;
            Debug.Log("퍼즐을 반전시킬 수 있습니다.");
            
            if(puzzle.transform.localScale.y == 1)
            {
                puzzle.transform.localScale = new Vector3(1, -1, 1);
            }
            else if (puzzle.transform.localScale.y == -1)
            {
                puzzle.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            selectPuzzle = false;
            Debug.Log("퍼즐을 반전시킬 수 없습니다.");
        }
    }
}
