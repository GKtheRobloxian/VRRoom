using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PrintTrail : MonoBehaviour
{
    public Transform paintbrush;
    CreateTrail creator;
    public Material trailMaterial;
    // Start is called before the first frame update
    void Start()
    {
        creator = GetComponent<CreateTrail>();
        Color color = Color.white;
        color.a = 0.0f;
        creator.trailPrefab.GetComponent<TrailRenderer>().startColor = color;
        creator.trailPrefab.GetComponent <TrailRenderer>().endColor = color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = (paintbrush.position - Vector3.forward * 0.5f) * 0.25f;
        GameObject[] currentPrint = GameObject.FindGameObjectsWithTag("Saved Trail");
        foreach (GameObject go in currentPrint)
        {
            Color color = Color.white;
            color.a = 0.0f;
            go.GetComponent<TrailRenderer>().endColor = color;
            go.GetComponent<TrailRenderer>().startColor = color;
            //go.GetComponent<TrailRenderer>().materials = Material[0];
        }
    }

    public void Print()
    {
        GameObject[] previousPrint = GameObject.FindGameObjectsWithTag("Previous Saved Trail");
        foreach (GameObject go in previousPrint)
        {
            Destroy(go);
        }

        GameObject[] currentPrint = GameObject.FindGameObjectsWithTag("Saved Trail");
        foreach(GameObject go in currentPrint)
        {
            Color color = Color.white;
            color.a = 1.0f;
            go.GetComponent<TrailRenderer>().endColor = color;
            go.GetComponent<TrailRenderer>().startColor = color;
            go.tag = "Previous Saved Trail";
        }
    }
}
