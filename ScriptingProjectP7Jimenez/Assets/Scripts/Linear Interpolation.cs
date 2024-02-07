using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{ /*
    void Start() 

    // In this case, result = 4
    When making games it can sometimes be useful to linearly interpolate between two values. This is done with a function called Lerp. Linearly interpolatinhg is finding a value that is some percentage between two given values. For example, 
    we could linearly interpolate between the numbers 3 and 5 by 50% to get the number 4. This is because 4 is 50% of the way between 3 and 5.

    float result = Mathf.Lerp (3f, 5f, 0.5f);
    In Unity there are several Lerp functions that can be used for different types. For the example  we have just used, the equivalent would be the Mathf.Lerp function and would look like this


    The Mathf.Lerp function takes 3 float parameters: one representing the value to interpolate from; another representing the value to interpolate to and a final float representing how far to interpolate. In this casethe interpolation value is 0.5 which means 50%. 
    If it was 0, the function would return the ‘from’ value and if it was 1 the function would return the ‘to’ value.

    Other examples of Lerp functions include Color.Lerp and Vector3.Lerp. These work in exactly the same way as Mathf.Lerp but the ‘from’ and ‘to’ values are of type Color and Vector3 respectively. 
    The third parameter in each case is still a float representing how much to interpolate. 
    The result of these functions is finding a colour that is some blend of two given colours and a vector that is some percentage of the way between the two given vectors.
    void Update() 
    {
        
    }    
}
