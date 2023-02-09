using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Exercise 7

    // Variables
    int OriginalFahrenheitInt = 0;
    int CalculatedCelsiusInt = 0;
    int CalculatedFahrenheitInt = 0;
    float OriginalFahrenheitFloat = 0;
    float CalculatedCelsiusFloat = 0;
    float CalculatedFahrenheitFloat = 0;
    double OriginalFahrenheitDouble = 0;
    double CalculatedCelsiusDouble = 0;
    double CalculatedFahrenheitDouble = 0;

    /// <summary>
    /// Print Original Fahrenheit value, then convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. 
    /// </summary>
    /// <param name="OriginalFahrenheitIntInput"></param>
    private void IntCalculation(int OriginalFahrenheitIntInput)
    {
        // Convert OriginalFahrenheit to Celsius
        CalculatedCelsiusInt = (5 / 9) * (OriginalFahrenheitIntInput - 32);

        // Convert CalculatedCelsius to CalculatedFahrenheit
        CalculatedFahrenheitInt = (9 / 5) * CalculatedCelsiusInt + 32;

        // Print Calulated answer
        Debug.Log($"Org.FahrenheitInt: {OriginalFahrenheitIntInput}; Cal.CelsiusInt: {CalculatedCelsiusInt}; Cal.FahrenheitInt: {CalculatedFahrenheitInt}");
    }

    /// <summary>
    /// Print Original Fahrenheit value, then convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. 
    /// </summary>
    /// <param name="OriginalFahrenheitFloatInput"></param>
    private void FloatCalculation(float OriginalFahrenheitFloatInput)
    {
        // Convert OriginalFahrenheit to Celsius
        CalculatedCelsiusFloat = (5F / 9F) * (OriginalFahrenheitFloatInput - 32);

        // Convert CalculatedCelsius to CalculatedFahrenheit
        CalculatedFahrenheitFloat = (9F / 5F) * CalculatedCelsiusFloat + 32;

        // Print Calulated answer
        Debug.Log($"Org.FahrenheitFloat: {OriginalFahrenheitFloatInput}; Cal.CelsiusFloat: {CalculatedCelsiusFloat}; Cal.FahrenheitFloat: {CalculatedFahrenheitFloat}");
    }

    /// <summary>
    /// Print Original Fahrenheit value, then convert to Celsius and print the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. 
    /// </summary>
    /// <param name="OriginalFahrenheitDoubleInput"></param>
    private void DoubleCalculation(double OriginalFahrenheitDoubleInput)
    {
        // Convert OriginalFahrenheit to Celsius
        CalculatedCelsiusDouble = (5D / 9D) * (OriginalFahrenheitDoubleInput - 32);

        // Convert CalculatedCelsius to CalculatedFahrenheit
        CalculatedFahrenheitDouble = (9D / 5D) * CalculatedCelsiusDouble + 32;

        // Print Calulated answer
        Debug.Log($"Org.FahrenheitDouble: {OriginalFahrenheitDoubleInput}; Cal.CelsiusDouble: {CalculatedCelsiusDouble}; Cal.FahrenheitDouble: {CalculatedFahrenheitDouble}");
    }

    // Start is called before the first frame update
    void Start()
    {
        // Original value = 0
        Debug.Log("----------------------------------Value = 0----------------------------------");
        OriginalFahrenheitInt = 0;
        OriginalFahrenheitFloat = 0F;
        OriginalFahrenheitDouble = 0D;
        IntCalculation(OriginalFahrenheitInt);
        FloatCalculation(OriginalFahrenheitFloat);
        DoubleCalculation(OriginalFahrenheitDouble);

        // Original value = 32
        Debug.Log("----------------------------------Value = 32----------------------------------");
        OriginalFahrenheitInt = 32;
        OriginalFahrenheitFloat = 32F;
        OriginalFahrenheitDouble = 32D;
        IntCalculation(OriginalFahrenheitInt);
        FloatCalculation(OriginalFahrenheitFloat);
        DoubleCalculation(OriginalFahrenheitDouble);

        // Original value = 212
        Debug.Log("----------------------------------Value = 212----------------------------------");
        OriginalFahrenheitInt = 212;
        OriginalFahrenheitFloat = 212F;
        OriginalFahrenheitDouble = 212D;
        IntCalculation(OriginalFahrenheitInt);
        FloatCalculation(OriginalFahrenheitFloat);
        DoubleCalculation(OriginalFahrenheitDouble);
    }
}
