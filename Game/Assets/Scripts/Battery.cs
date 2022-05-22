using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public double Charge = 500;
    public double Usage = 0;
    public double Charge2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Charge > 0)
        {
            Charge -= Usage*0.00001;
        }
        Charge2 = Charge / 500;
    }
}
