using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 distance;
    public float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position=Vector3.Lerp(this.transform.position, target.transform.position + distance, followSpeed);
    }
}
