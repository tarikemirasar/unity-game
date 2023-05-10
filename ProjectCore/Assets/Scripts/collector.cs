using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collector : MonoBehaviour

{
    int height;
    GameObject mainCube;
    // Start is called before the first frame update
    void Start()
    {
        mainCube = GameObject.Find("cubeMain");
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }
    
    public void decreaseHeight()
    {
        height -= 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collect" && other.gameObject.GetComponent<collectibleCube>().getIsCollected() == false)
        {
            height += 1;
            other.gameObject.GetComponent<collectibleCube>().setCollected();
            other.gameObject.GetComponent<collectibleCube>().setIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
        }

        if(other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(0);
        }
    }
}
