using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    PlayQuickSound sound;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        sound = GetComponent<PlayQuickSound>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        float velocity = body.velocity.magnitude;
        if (velocity < 2f)
        {
            sound.volume = velocity / 2f;
            sound.Play();
        }
        else
        {
            sound.volume = 1f;
            sound.Play();
        }
    }
}
