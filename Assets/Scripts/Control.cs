using System;
using System.Runtime.InteropServices.WindowsRuntime;
// using NUnit.Framework;
using Unity.Collections;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        transform.position = new Vector3(-7, 0, 0);
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * Time.deltaTime * speed, 0, 0);
        // Debug.Log(horizontal);
    }
}
