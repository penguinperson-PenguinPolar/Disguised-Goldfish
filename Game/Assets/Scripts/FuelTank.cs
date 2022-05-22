using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelTank : MonoBehaviour
{
    public double FillLevel = 500;
    public double Usage = 0;
    public double FillLevel2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FillLevel > 0)
        {
            FillLevel -= Usage * 0.00001;
        }
        FillLevel2 = FillLevel / 500;
    }
}
