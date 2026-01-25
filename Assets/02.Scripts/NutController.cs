using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shoot(new Vector3(0, 200, 2000));
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
}
