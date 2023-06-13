using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerDrag : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 mouseOffset;
    private Camera mainCam;

    private void Awake()
    {
        mainCam = Camera.main;
    }

    private void OnMouseDown()
    {
        mouseOffset = transform.position - theMouse();
    }

    private void OnMouseDrag()
    {
        transform.position = theMouse()+mouseOffset;
        
    }

    public Vector3 theMouse()
    {
        Vector3 myMousePos= mainCam.ScreenToWorldPoint(Input.mousePosition);
        myMousePos.z=0;
        return myMousePos;

    }



}
