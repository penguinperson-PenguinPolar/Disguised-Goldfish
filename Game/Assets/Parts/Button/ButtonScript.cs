using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject toTurnOn;
    public string scriptName;
    public string variableName;
    public void WhenClicked()
    {
        if (toTurnOn.GetComponent(scriptName).dictionaryBool[variableName] == false) {
            toTurnOn.GetComponent(scriptName).dictionaryBool[variableName] = true;
        } else {
            toTurnOn.GetComponent(scriptName).dictionaryBool[variableName] = false;
        }
    }
}
