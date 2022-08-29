using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Amount : MonoBehaviour
{
    public Items_Info itemData;
    public TextMeshProUGUI amountText;

    public int count = 1;

    // Update is called once per frame
    void Update()
    {
        amountText.text = count.ToString();
    }
}
