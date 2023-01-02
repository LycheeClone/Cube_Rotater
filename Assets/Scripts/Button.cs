using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Button : MonoBehaviour
{
    bool isClickable = true;
    public void ButtonClick(){
        float cubeAxisX = Mathf.Abs(Cube.Instance.transform.rotation.eulerAngles.x);
        if(cubeAxisX <= 20 || (cubeAxisX >= 90 && cubeAxisX <= 110) ||(cubeAxisX >= 190 && cubeAxisX <= 210)||(cubeAxisX >= 270 && cubeAxisX <= 290) && isClickable)
        {
            Counter.Instance.ScoreIncrease();
            isClickable = false;
            StartCoroutine(ButtonClickReset());  
        }
    }
    IEnumerator ButtonClickReset()
    {
        yield return new WaitForSeconds(1f);
        isClickable = true;
    }
}
