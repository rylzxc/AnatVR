using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShiftObject : MonoBehaviour
{
    private List<GameObject> objects = null;
    private int listCount = 0;
    
    public GameObject horizontalSlider;
    public GameObject verticalSlider;
    
    private Vector3 previousPosition;
    private Quaternion previousRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        objects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Selectable"));
        listCount = objects.Count;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Previous rotation: " + previousRotation);
    }

    public void BringObjectCloser() {
        
        if (ObjectTracker.objectTracker != null && objects.Count == listCount) {
            if (ObjectTracker.objectTracker.activeInHierarchy) {
                Vector3 targetPosition = new Vector3(1.90f, 0.30f, 1.30f);

                previousPosition = ObjectTracker.objectTracker.transform.position;
                previousRotation = ObjectTracker.objectRotation;
                ObjectTracker.objectTracker.transform.position = targetPosition;

                objects.Remove(ObjectTracker.objectTracker);
                
                foreach (GameObject obj in objects) {
                    obj.SetActive(false);
                }

                horizontalSlider.SetActive(true);
                verticalSlider.SetActive(true);
            } else {
                Debug.Log("No object selected!");
            }
        } else {
            // Revert back to original position
            foreach (GameObject obj in objects) {
                obj.SetActive(true);
            }

            horizontalSlider.GetComponent<Slider>().value = 0f;
            verticalSlider.GetComponent<Slider>().value = 0f;

            ObjectTracker.objectTracker.transform.position = previousPosition;
            ObjectTracker.objectTracker.transform.rotation = previousRotation;
            ObjectTracker.objectRotation = previousRotation;

            objects.Add(ObjectTracker.objectTracker);

            horizontalSlider.SetActive(false);
            verticalSlider.SetActive(false);

        }
    }
}
