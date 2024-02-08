using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRotWithSlider : MonoBehaviour
{
    public float yRotToSet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetZRotation()
    {
        float yRot = GameObject.Find("Rotation Slider").GetComponent<Slider>().value;
        yRotToSet = yRot * 360f;
        transform.localEulerAngles = new Vector3(0, yRotToSet, 0);
    }
}
