using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    //camera�̃I�u�W�F�N�g
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //��]
        this.transform.Rotate(0, 3, 0);

        //camera�̃I�u�W�F�N�g���擾
        this.camera = GameObject.Find("Main Camera");

        if (this.transform.position.z < this.camera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
