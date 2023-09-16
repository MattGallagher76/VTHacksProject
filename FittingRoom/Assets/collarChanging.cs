using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collarChanging : MonoBehaviour
{
    public string textVal;
    public int numberVal;
    public GameObject inputField;
    
    

    public void StoreVal(){
        textVal = inputField.GetComponent<Text>().text;
        numberVal = int.Parse(textVal, System.Globalization.NumberStyles.Integer);
        Debug.Log(numberVal);
    }
}
