using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTrails : MonoBehaviour
{
    GameObject[] trails;
    // Start is called before the first frame update
    void Start()
    {
        trails = GameObject.FindGameObjectsWithTag("Trail");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject trail in trails)
        {
            trail.transform.Translate(Vector3.right * 1.5f + Vector3.back * 0.5f);
            trail.transform.SetParent(GameObject.Find("Trail Parent").transform);
        }
    }
}
