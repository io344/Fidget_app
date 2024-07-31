using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextShiz : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    int num = 0;

    void Start()
    {
        text.text = "TOUCH!";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            num++;
            text.text = num.ToString();
        }
    }
}
