using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUntilHalf : MonoBehaviour
{

    public bool rotating = false;
    float rotateTimer = 0;
    int rotateCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotating && rotateCount % 2 == 0)
        {
            transform.Rotate(Vector3.forward * 270 * Time.deltaTime);
            rotateTimer += Time.deltaTime;
        }
        else if(rotating && rotateCount % 2 == 1)
        {
            transform.Rotate(Vector3.forward * -270 * Time.deltaTime);
            rotateTimer += Time.deltaTime;
        }
        if (rotateTimer > (0.75f))
        {
            rotating = false;
        }
    }

    public void SetRotating()
    {
        if (!rotating)
        {
            rotating = true;
            rotateTimer = 0;
            rotateCount += 1;
        }
    }
}
