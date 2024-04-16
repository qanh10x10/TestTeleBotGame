using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    int count = 0;
    private void Start()
    {
        text.text = count.ToString();
    }
    public void OnClickBtn()
    {
        count++;
        text.text = count.ToString();
    }
}
