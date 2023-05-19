using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    
    public void SelectObject(GameObject obj) 
    {
        ObjectTracker.objectTracker = obj;
        //Debug.Log("Selected object " + ObjectTracker.objectTracker.name);
    }

}