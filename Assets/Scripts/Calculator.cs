/*This was the ALTERNATIVE code that i wrote but not all functionalities were working but the code is more simple and gets the job done for beginner 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField inputField;
    private float inputValue = 0f;
    private float currentValue = 0f;
    private char mathOperator;

    public void InputNumber(string number)
    {
        inputField.text += number;
    }

    public void InputOperator(string op)
    {
        inputValue = float.Parse(inputField.text);
        inputField.text = "";
        mathOperator = op[0];
    }

    public void Calculate()
    {
        float newValue = float.Parse(inputField.text);

        switch(mathOperator)
        {
            case '+':
                currentValue = inputValue + newValue;
                break;
            case '-':
                currentValue = inputValue - newValue;
                break;
            case '*':
                currentValue = inputValue * newValue;
                break;
            case '/':
                currentValue = inputValue / newValue;
                break;
        }

        inputField.text = currentValue.ToString();
    }

    public void Clear()
    {
        inputField.text = "";
        inputValue = 0f;
        currentValue = 0f;
    }
}
*/
