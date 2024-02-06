using System.Collections;
using System.Collections.Generic;
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
        creator.trailPrefab.GetComponent<TrailRenderer>().material = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = (paintbrush.position - Vector3.forward * 0.5f + Vector3.right * 1.5f) * 0.25f;
    }

    public void Print()
    {
        creator.trailPrefab.GetComponent<TrailRenderer>().material = trailMaterial;
    }

    public void ClearTrailMat()
    {
        creator.trailPrefab.GetComponent<TrailRenderer>().material = null;
    }
}
