using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject spawn;

    private PlacementIndicator indicator;

    // Start is called before the first frame update
    void Start()
    {
        indicator = FindObjectOfType<PlacementIndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(spawn, indicator.transform.position, indicator.transform.rotation);
        }
    }

    public void Activate()
    {
        GameObject obj = Instantiate(spawn, indicator.transform.position, indicator.transform.rotation);
    }
}
