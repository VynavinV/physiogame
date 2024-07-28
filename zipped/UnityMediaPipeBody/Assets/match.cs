using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class match : MonoBehaviour
{
    public Transform me;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target.position = me.position;
    }
}
