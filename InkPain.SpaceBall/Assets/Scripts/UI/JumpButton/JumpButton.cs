using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool jump = false;
    public void OnPointerDown(PointerEventData eventData)
    {

        jump = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        jump = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
