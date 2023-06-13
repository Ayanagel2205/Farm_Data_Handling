using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WorkerMovement : MonoBehaviour
{
    // Start is called before the first frame update


    //[SerializeField] private GameObject myWorker;
    //[SerializeField] private Rigidbody2D myWorkerRigid;
    private Rigidbody2D dragRigid;
    
    private Vector3 screenPos;
    private Collider2D dragCol;
    private float mouseX;
    private float mouseY;
    private float screenDistance;


    private Vector3 offset;

    private void Awake()
    {
       
        //screenPos = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
    }

    void Start()
    {
        
        EventTrigger theTrigger = GetComponent<EventTrigger>();
        EventTrigger.Entry objEntry = new EventTrigger.Entry();
        objEntry.eventID = EventTriggerType.Drag;
        objEntry.callback.AddListener((data) => { OnMyDrag((PointerEventData)data); });
        theTrigger.triggers.Add(objEntry);

    }


    public void OnMyDrag(PointerEventData listenerInfo)
    {
       
        Ray camRay = Camera.main.ScreenPointToRay(listenerInfo.position);
        Vector3 rayPos = camRay.GetPoint(Vector3.Distance(transform.position, Camera.main.transform.position));
        transform.position = rayPos;

    }




    // Update is called once per frame
  /*  void Update()
    {
        screenPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragCol = Physics2D.OverlapPoint(screenPos);

        if (Input.GetMouseButtonDown(0) && dragCol)
        {
            offset = myWorkerRigid.transform.position - screenPos;
            dragRigid = myWorker.gameObject.GetComponent<Rigidbody2D>();


        }

        if (Input.GetMouseButtonDown(0) && myWorker)
        {
            dragRigid = null;


        }




        
    }*/


   /* private void FixedUpdate()
    {
        if (dragRigid)
        {
            Vector2 dragVect = screenPos + offset;
            myWorkerRigid.MovePosition(dragVect);



        }
    }*/



    /*private void OnMouseDown()
    {

        screenPos = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
        

        Vector3 mouseBound = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPos.z);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(mouseBound);
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenP = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPos.z);
        Vector3 curObjPos = Camera.main.ScreenToWorldPoint(curScreenP) + offset;
        transform.position = curObjPos;
        
    }*/

}
