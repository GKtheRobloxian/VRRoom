using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTrails : MonoBehaviour
{
    GameObject[] trails;
    GameObject[] trailSaved;
    // Start is called before the first frame update
    void Start()
    {
        trails = GameObject.FindGameObjectsWithTag("Trail");
    }

    // Update is called once per frame
    void Update()
    {
        trails = GameObject.FindGameObjectsWithTag("Trail");
        trailSaved = GameObject.FindGameObjectsWithTag("Saved Trail");
    }

    public void TeleportTrails()
    {
        foreach (GameObject trails in trailSaved)
        {
            Destroy(trails);
        }

        foreach (GameObject trail in trails)
        {
            trail.transform.Translate(Vector3.right * 1.5f + Vector3.back * 0.5f);
            trail.transform.SetParent(GameObject.Find("Trail Parent").transform);
            trail.transform.localScale /= 4f;
            trail.transform.localPosition /= 4f;
            trail.gameObject.tag = "Saved Trail";
        }
    }
}
