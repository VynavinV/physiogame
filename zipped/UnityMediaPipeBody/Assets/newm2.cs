using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newm2 : MonoBehaviour
{
    public Vector3 minRange;
    public Vector3 maxRange;
    public cubemanager2 man;
    public GameObject par;
    public int e;
    public Transform a;
    public Transform b;
    public Transform c;
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
        man.hand2 = true;

    }
    public void mv1()
    {
        par.SetActive(true);
        Invoke("mv", 2);
    }
    public void mv()
    {
        if (e == 1)
        {
            this.transform.position = a.position;
            e++; ;
        }
        else if (e ==2 )
        {
            this.transform.position = b.position;
            e++;

        }
        else if (e ==3 )
        {
            this.transform.position = c.position;
            e = 1;
        }

        // Optionally reset hands to 0 if you want to move the object again
        man.full = false;
        man.hand1 = false;
        man.hand2 = false;
        par.SetActive(false);

    }

    private void OnTriggerExit(Collider other)
    {
        man.hand2 = false;
    }
}
