using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStats : MonoBehaviour
{
    public GameObject GameObjEngine;
    Engine engine;
    public GameObject GameObjBattery;
    Battery battery;
    public GameObject GameObjFuelTank;
    FuelTank fuelTank;
    public Text Speed;
    public Text RPM;
    public Text Temp;
    public Text BatteryTxt;
    public Text Fuel;
    // Start is called before the first frame update
    void Awake()
    {
        engine = GameObjEngine.GetComponent<Engine>();
        battery = GameObjBattery.GetComponent<Battery>();
        fuelTank = GameObjFuelTank.GetComponent<FuelTank>();
    }

    // Update is called once per frame
    void Update()
    {
        Speed.text = "Speed: " + engine.Speed.ToString();
        RPM.text = "RPM: " + engine.RPM.ToString();
        Temp.text = "Temp: " + engine.Temp.ToString();
        BatteryTxt.text = "Battery: " + battery.Charge.ToString();
        Fuel.text = "Fuel: " + fuelTank.FillLevel.ToString();
    }
}
