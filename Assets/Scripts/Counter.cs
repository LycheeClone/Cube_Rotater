using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Counter : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI counterText;
    float count = 0;
    public static Counter Instance;
    void Awake()
    {
        Instance = this;
        counterText.text = count.ToString();
    }
    public void ScoreIncrease(){
        count ++;
        counterText.text = count.ToString();
    }
}
