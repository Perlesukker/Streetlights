using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sun : MonoBehaviour
{
    public Slider mySlide;

    public Light daSun;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(mySlide.value, transform.rotation.y, transform.rotation.z);
    }
}
