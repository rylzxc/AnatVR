using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GhostObject : MonoBehaviour
{
    private float previousAlpha = 1.0f;
    private List<GameObject> objects;

    public void GhostTheObject()
    {
        if (ObjectTracker.objectTracker != null) {
            objects = new List<GameObject>();
            objects.Add(ObjectTracker.objectTracker);
            ObjectTracker.objectTracker.SetActive(false);

        }
    }
}
