using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActuallyHide : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide() {
        if (ObjectTracker.objectTracker != null) 
        {
            if (ObjectTracker.objectTracker.activeInHierarchy)
            {
                ObjectTracker.objectTracker.SetActive(false);
            }
            else
            {
                ObjectTracker.objectTracker.SetActive(true);
            }
        }
        else
        {
            Debug.Log("No Object selected!");
        }
    }
}
