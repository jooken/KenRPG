using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime : 1프레임 당 걸리는 시간
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
