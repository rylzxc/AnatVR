using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftObject : MonoBehaviour
{
    public List<GameObject> objects = null;
    private int listCount = 0;
    private Vector3 previousPosition;
    // Start is called before the first frame update
    void Start()
    {
        objects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Selectable"));
        listCount = objects.Count;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BringObjectCloser() {
        
        if (ObjectTracker.objectTracker != null && objects.Count == listCount) {
            if (ObjectTracker.objectTracker.activeInHierarchy) {
                Vector3 targetPosition = new Vector3(1.90f, 0.30f, 1.30f);

                previousPosition = ObjectTracker.objectTracker.transform.position;
                ObjectTracker.objectTracker.transform.position = targetPosition;

                objects.Remove(ObjectTracker.objectTracker);
                
                foreach (GameObject obj in objects) {
                    obj.SetActive(false);
                }
            }
        } else {
            // Revert back to original position
            foreach (GameObject obj in objects) {
                obj.SetActive(true);
            }

            ObjectTracker.objectTracker.transform.position = previousPosition;

            objects.Add(ObjectTracker.objectTracker);

        }
    }
}
