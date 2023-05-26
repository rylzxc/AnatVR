using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCanvas : MonoBehaviour
{
    public GameObject childObject;
    private bool isHovered = false;
    private bool isSelected = false;
    public void OnHoverOver()
    {
        isHovered = true;
        childObject.SetActive(true);
    }

    public void OnSelect() 
    {
        isSelected = true;
        if (isSelected | isHovered) {
            childObject.SetActive(true);
        }
        ObjectTracker.childObjectLabel = childObject;
    }

    public void OnHoverExit()
    {
        isHovered = false;
        if (!isSelected) {
            childObject.SetActive(false);
        }

    }

    public void OnDeselect() 
    {
        isSelected = false;
        if (!isSelected) {
            childObject.SetActive(false);
        }
    }
}
