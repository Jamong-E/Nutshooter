using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutController : MonoBehaviour
{
    GameObject target;
    private bool stuck = false;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("target");
    }

    void Update()
    {
        //if (stuck) { transform.Translate(target.GetComponent<TargetController>().toward(), 0, 0, Space.World); }
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        //Destroy(GetComponent<SphereCollider>());
        GetComponent<SphereCollider>().enabled = false;
        if (collision.gameObject.name == "target") { /*stuck = true;*/ transform.parent = collision.transform; }
    }
}
