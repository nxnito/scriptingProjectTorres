using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public Text horizontalValueDisplayText;
    public Text vericalValueDisplayText;
    public float hRange;
    public float vRange;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("vertical");
        float xPos = h * hRange;
        float yPos = vRange;

        transform.position = new Vector3(xPos, 0, yPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        vericalValueDisplayText.text = v.ToString("F2");
    }
}
