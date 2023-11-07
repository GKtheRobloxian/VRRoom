using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject center;
    public GameObject hour;
    public GameObject minute;
    public GameObject second;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hour.transform.rotation = Quaternion.Euler(((30 * System.DateTime.Now.Hour) + (0.5f * (System.DateTime.Now.Minute%60)) + (0.5f/60 * (System.DateTime.Now.Second%60))), 180, 0);
        minute.transform.rotation = Quaternion.Euler(((6 * System.DateTime.Now.Minute) + (0.1f * (System.DateTime.Now.Second%60))), 180, 0);
        second.transform.rotation = Quaternion.Euler(6 * System.DateTime.Now.Second, 180, 0);
    }
}
