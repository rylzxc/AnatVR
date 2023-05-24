using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    void Update() 
    {

    }

    public void SelectObject(GameObject obj) 
    {
        ObjectTracker.objectTracker = obj;
        ObjectTracker.objectRotation = obj.transform.rotation;
    }
}