using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Puzzle : MonoBehaviour, IPointerClickHandler, IDragHandler
{
    [SerializeField] Image puzzle1;
    Vector2 originPosition; //퍼즐 조각의 원래 위치

    // Start is called before the first frame update
    void Start()
    {
        originPosition = transform.position;
    }

    public void OnPointerClick(PointerEventData eventData) //오브젝트를 클릭했을 때?
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            puzzle1.transform.Rotate(0, 0, 90); //z축 기준으로 마우스 오른쪽 버튼을 누를 때마다 90도씩 회전
        }
    }

    public void OnDrag(PointerEventData eventData) //오브젝트를 끌고 있는 중일 때
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            puzzle1.transform.position = eventData.position;
        }
    }
}
