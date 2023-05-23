using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObjectVerticallyWithSlider : MonoBehaviour
{
    private Quaternion initialRotation;
    private float previousSliderValue;

    // Start is called before the first frame update
    void Start()
    {
        previousSliderValue = 0f;
        initialRotation = ObjectTracker.objectRotation;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RotateMyObject(Slider slider)
    {
        float currentSliderValue = slider.value;
        
        // Determine rotation direction based on slider movement
        float rotationAmount = currentSliderValue - previousSliderValue;

        // Update previous slider value
        previousSliderValue = currentSliderValue;

        // Rotate the object
        ObjectTracker.objectTracker.transform.rotation = Quaternion.Euler(rotationAmount * 360f, 0f, 0f) * ObjectTracker.objectTracker.transform.rotation;
    }
}