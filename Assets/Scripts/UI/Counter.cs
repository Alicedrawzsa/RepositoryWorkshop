using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI text;
    private int counter;

    public void AddToCounter(int num) {
        counter += num;
        text.SetText(counter.ToString());
    }
}
