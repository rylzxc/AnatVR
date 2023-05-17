using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    private GameObject selectedObject;

    public void Hide()
    {
        if (selectedObject.activeInHierarchy) {
            selectedObject.SetActive(false);
        } else {
            selectedObject.SetActive(true);
        }

    }

    public void SelectObject(GameObject obj) 
    {
        selectedObject = obj;
    }

}
