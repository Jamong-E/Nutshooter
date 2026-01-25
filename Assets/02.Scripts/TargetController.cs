using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -18) { direction = 1; }
        if (transform.position.x > 18) { direction = -1; }
        transform.Translate(direction * 0.2f, 0, 0);
    }
    public float toward() { return direction * 0.2f; }
}
