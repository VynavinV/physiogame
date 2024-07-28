using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cubemanager : MonoBehaviour
{
    public bool hand1 = false;
    public bool hand2 = false;
    public bool full = false;
    public move move;
    public newm newm;
    public Text txt;
    public int score;
    public int scen;

    private void Update()
    {
        if (hand1)
        { 
            if (hand2)
            {
                full = true;
            }
        }

        if (full) 
        {
            newm.mv1();
            move.mv1();
            full = false;
            hand2 = false;
            hand1 = false;
            score++;
            txt.text = score.ToString();
            if (score > 9)
            {
                SceneManager.LoadScene(scen);
            }
        }
    }
}
