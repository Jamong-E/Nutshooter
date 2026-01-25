using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bam;
    float deltaTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && deltaTime > 0.2f)
        {
            GameObject nut = Instantiate(bam);
            //float dx = (Input.mousePosition.x - Screen.width / 2) / Screen.width * 2000;
            //float dy = (Input.mousePosition.y - Screen.height / 2) / Screen.height * 1000;
            //nut.GetComponent<NutController>().Shoot(new Vector3(dx, 200 + dy, 2000));
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            nut.GetComponent<NutController>().Shoot(worldDir.normalized * 2000);
            deltaTime = 0;
        }
    }
}
