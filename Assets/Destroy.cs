using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //cameraのオブジェクト
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {

        //cameraのオブジェクトを取得
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
