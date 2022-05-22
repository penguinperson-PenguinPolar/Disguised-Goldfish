using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public GameObject GameObjEngine;
    Engine engine;
    // Start is called before the first frame update
    void Awake()
    {
        engine = GameObjEngine.GetComponent<Engine>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(engine.Speed, 0f, 0f, Space.Self);
    }
}
