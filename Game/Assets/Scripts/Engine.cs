using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public int EngineLevel = 1;
    Dictionary<string, double> dictionaryDouble = new Dictionary<string, double>();
    dictionaryDouble.Add("Throttle",0.0f);

    Battery battery;
    public GameObject GameObjBattery;
    public double Electricity = 0;

    FuelTank fuelTank;
    public GameObject GameObjFuelTank;
    public double Fuel = 0;

    public double RPM_Limit = 20.0f;
    public double Temp;
    public double RPM = 0.0f;
    public double Coolant = 0.0f;
    public float Speed = 0.0f;
    Dictionary<string, bool> dictionaryBool = new Dictionary<string, bool>();
    dictionaryBool.Add("engineOn",false);
    // Start is called before the first frame update
    void Awake()
    {
        battery = GameObjBattery.GetComponent<Battery>();
        fuelTank = GameObjFuelTank.GetComponent<FuelTank>();
    }

    // Update is called once per frame
    void Update()
    {
        Electricity = battery.Charge2;
        if (dictionaryBool["engineOn"] == true)
        {
            if (EngineLevel == 1)
            {
                battery.Usage = 1 * dictionaryDouble("Throttle");
                fuelTank.Usage = 1 * dictionaryDouble("Throttle");
                if (RPM >= RPM_Limit)
                {
                    RPM = RPM_Limit;
                }
                else
                {
                    RPM += 0.05;
                }
                Temp = (RPM * 3.25) - (Coolant * 0.01);
            }
            else if (EngineLevel == 2)
            {
                battery.Usage = 1.5 * dictionaryDouble("Throttle");
                fuelTank.Usage = 1.5 * dictionaryDouble("Throttle");
                if (RPM >= RPM_Limit)
                {
                    RPM = RPM_Limit;
                }
                else
                {
                    RPM += 0.1;
                }
                Temp = (RPM * 3.5) - (Coolant * 0.02);
            }
            else if (EngineLevel == 3)
            {
                battery.Usage = 3 * dictionaryDouble("Throttle");
                fuelTank.Usage = 3 * dictionaryDouble("Throttle");
                if (RPM >= RPM_Limit)
                {
                    RPM = RPM_Limit;
                }
                else
                {
                    RPM += 0.3;
                }
                Temp = (RPM * 4) - (Coolant * 0.04);
            }
            RPM = (RPM * Electricity) * Fuel;
            Speed = (float)RPM * (float)dictionaryDouble("Throttle");
        }
        else
        {
            if (RPM > 0)
            {
                RPM -= 0.5;
            }
            if (Temp > 0)
            {
                Temp -= 0.5;
            }
        }
    }
}
