using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Scaler : MonoBehaviour
{
    public TMP_InputField i1__j1;
    public TMP_InputField i1__j2;
    public TMP_InputField i2__j1;
    public TMP_InputField i2__j2;
    // private TextMeshPro textcomponent;
    void Start()
    {
        transform.position = new Vector2(0f, 0f);
        transform.localScale = new Vector2(0.25f, 5f);

        //  textcomponent = i1_j1.GetComponent<TextMeshPro>();
    }

    void Update()
    {
        // Debug.Log(i1__j1.text);
        // Debug.Log(textcomponent.text);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Dot")
        {
            float[] values = Scale((float)other.gameObject.transform.localScale.x,
            (float)other.gameObject.transform.localScale.y, float.Parse(i1__j1.text), float.Parse(i2__j2.text));

            // Debug.Log((values[0],values[1]));
            Debug.Log((i1__j1.text, i1__j2.text, i2__j1.text, i2__j2.text));
        }
    }
    public float[] Scale(float x, float y, float scaleX, float scaleY)
    {
        float[] lst = { x * scaleX, y * scaleY };
        return lst;
    }
}
