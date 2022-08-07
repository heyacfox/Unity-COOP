using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberVariable : MonoBehaviour
{
    public float number;

    public void AddToNumber(float add)
    {
        number += add;
    }

    public void SubtractFromNumber(float subtract)
    {
        number -= subtract;
    }

    public void SetNumber(float newNumber)
    {
        number = newNumber;
    }

    


}
