using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    private List<GameObject> objects = null;
    // Start is called before the first frame update
    void Start()
    {
        objects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Selectable"));
        foreach (GameObject obj in objects) {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
