using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Nuvol : MonoBehaviour
{

    public GameObject clon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.right * Time.deltaTime, Space.World);

       

            if (transform.position.x < -8)
            {
                clon=Instantiate(this.gameObject, new Vector3(8f, transform.position.y, transform.position.z), Quaternion.identity);
                Destroy(this.gameObject);
            }
       

    }
}
