using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 minRange;
    public Vector3 maxRange;
    public cubemanager man;
    public GameObject par;
    public bool e;
    public Transform a;
    public Transform b;
    // Start is called before the first frame update
    void Start()
    {
        // Initialization if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic if needed
    }

    private void OnTriggerEnter(Collider other)
    {
        man.hand1 = true;

    }
    public void mv1()
    { 
        par.SetActive(true);
        Invoke("mv", 2);
    }
    public void mv()
    {
        if (e)
        {
            this.transform.position = a.position;
            e = false;  
        }
        else
        {
            this.transform.position = b.position;
            e = true;

        }

        // Optionally reset hands to 0 if you want to move the object again
        man.full = false;
        man.hand1 = false;
        man.hand2 = false;
        par.SetActive(false);

    }

    private void OnTriggerExit(Collider other)
    {
        man.hand1 = false;
    }
}
