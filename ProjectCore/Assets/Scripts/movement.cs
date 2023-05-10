using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float horizontalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, horizontalSpeed * Time.deltaTime);
        var myPosX = transform.position.x;        
        var myPosZ = transform.position.z;        

        if(myPosX < -4.5){
            transform.position = new Vector3(-4.50f, transform.position.y , transform.position.z);
        }

        if(myPosX > 4.5){
            transform.position = new Vector3(4.50f, transform.position.y , transform.position.z);
        }
    }
}
