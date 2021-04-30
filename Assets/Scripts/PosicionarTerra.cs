using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarTerra : MonoBehaviour
{

    public GameObject Terra;

    // Start is called before the first frame update.
    void Start()
    {
        Terra.transform.position = new Vector3(0.45f, -1.75f, -4.85f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
