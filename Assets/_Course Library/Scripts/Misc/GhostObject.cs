using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GhostObject : MonoBehaviour
{
    private float desiredAlpha = 0.0f;
    private Material material;

    public void GhostTheObject()
    {
        if (ObjectTracker.objectTracker != null) {
            GameObject selectedObj = ObjectTracker.objectTracker;
            Renderer renderer = selectedObj.GetComponent<Renderer>();
            material = renderer.materials[1];

            Color color = material.color;
            color.a = (color.a != desiredAlpha) ? desiredAlpha : 1.0f;
            material.color = color;
        }
    }
}
