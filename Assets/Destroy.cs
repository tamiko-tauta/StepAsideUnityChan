using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //camera�̃I�u�W�F�N�g
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {

        //camera�̃I�u�W�F�N�g���擾
        this.camera = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.camera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
