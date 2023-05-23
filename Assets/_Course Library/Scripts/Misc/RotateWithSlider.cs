using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateWithSlider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void RotateHorizontally(Slider horizontalSlider) 
    // {
    //     currentSliderValue = horizontalSlider.value;
        
    //     // Determine rotation direction based on slider movement
    //     rotationAmount = currentSliderValue - previousSliderValue;

    //     // Update previous slider value
    //     previousSliderValue = currentSliderValue;

    //     // Rotate the object
    //     ObjectTracker.objectTracker.transform.rotation = Quaternion.Euler(0f, rotationAmount * 360f, 0f) * ObjectTracker.objectTracker.transform.rotation;

    // }

    // public void RotateVertically(Slider verticalSlider) 
    // {
    //     currentSliderValue = verticalSlider.value;
        
    //     // Determine rotation direction based on slider movement
    //     rotationAmount = currentSliderValue - previousSliderValue;

    //     // Update previous slider value
    //     previousSliderValue = currentSliderValue;

    //     // Rotate the object
    //     ObjectTracker.objectTracker.transform.rotation = Quaternion.Euler(rotationAmount * 360f, 0f, 0f) * ObjectTracker.objectTracker.transform.rotation;
    // }
}
