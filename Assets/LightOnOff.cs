using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light myLight;
    public bool amIOn;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        amIOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        myLight.enabled = amIOn;
    }

    public void OnOff()
    {
        amIOn = !amIOn;
    }
}
