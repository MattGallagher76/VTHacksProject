using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UnityEngine.UI;

public class UMAFiddler : MonoBehaviour
{

    private DynamicCharacterAvatar avatar;
    private Dictionary<string, DnaSetter> dna;

    public string collarTextVal;
    public int collarNumberVal;
    public GameObject collarInputField;


    public string waistTextVal;
    public int waistNumberVal;
    public GameObject waistInputField;


    public string hipTextVal;
    public int hipNumberVal;
    public GameObject hipInputField;
    
    public string chestTextVal;
    public int chestNumberVal;
    public GameObject chestInputField;

    public string torsoTextVal;
    public int torsoNumberVal;
    public GameObject torsoInputField;

    public string shoulderTextVal;
    public int shoulderNumberVal;
    public GameObject shoulderInputField;

    public string armLengthTextVal;
    public int armLengthNumberVal;
    public GameObject armLengthInputField;

    
    public string armWidthTextVal;
    public int armWidthNumberVal;
    public GameObject armWidthInputField;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        avatar = GetComponent<DynamicCharacterAvatar>();
       
        
    }

    // Update is called once per frame
    void Update()
    { 
        
            if(dna == null){
                dna = avatar.GetDNA();
            }

            //dna["headSize"].Set(1f);
            //vatar.BuildCharacter();
        
        
    }

     public void StoreCollarVal(){
        collarTextVal = collarInputField.GetComponent<Text>().text;
        collarNumberVal = int.Parse(collarTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = collarTextVal.Length;
        float collarChange = collarNumberVal * 0.01f;

        Debug.Log(collarNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["neckThickness"].Set(0.5f + collarChange);
            avatar.BuildCharacter();
    }

    
     public void StoreWaistVal(){
        waistTextVal = waistInputField.GetComponent<Text>().text;
        waistNumberVal = int.Parse(waistTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = waistTextVal.Length;
        float waistChange = waistNumberVal * 0.01f;

        Debug.Log(waistNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["waist"].Set(0.5f + waistChange);
            avatar.BuildCharacter();
    }

    public void StoreHipVal(){
        hipTextVal = hipInputField.GetComponent<Text>().text;
        hipNumberVal = int.Parse(hipTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = hipTextVal.Length;
        float hipChange = hipNumberVal * 0.01f;

        Debug.Log(hipNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["gluteusSize"].Set(0.5f + hipChange);
            avatar.BuildCharacter();
    }

     public void StoreChestVal(){
        chestTextVal = chestInputField.GetComponent<Text>().text;
        chestNumberVal = int.Parse(chestTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = chestTextVal.Length;
        float chestChange = chestNumberVal * 0.01f;

        Debug.Log(chestNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["breastSize"].Set(0.5f + chestChange);
            avatar.BuildCharacter();
    }

     public void StoreTorsoVal(){
        torsoTextVal = torsoInputField.GetComponent<Text>().text;
        torsoNumberVal = int.Parse(torsoTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = torsoTextVal.Length;
        float torsoChange = torsoNumberVal * 0.01f;

        Debug.Log(shoulderNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["height"].Set(0.5f + torsoChange);
            avatar.BuildCharacter();
    }

    public void StoreShoulderVal(){
        shoulderTextVal = shoulderInputField.GetComponent<Text>().text;
        shoulderNumberVal = int.Parse(shoulderTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = shoulderTextVal.Length;
        float shoulderChange = shoulderNumberVal * 0.01f;

        Debug.Log(shoulderNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["upperMuscle"].Set(0.5f + shoulderChange);
            avatar.BuildCharacter();
    }

    public void StoreArmLengthVal(){
        armLengthTextVal = armLengthInputField.GetComponent<Text>().text;
        armLengthNumberVal = int.Parse(armLengthTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = armLengthTextVal.Length;
        float armLengthChange = armLengthNumberVal * 0.01f;

        Debug.Log(armLengthNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["forearmLength"].Set(0.5f + armLengthChange);
            avatar.BuildCharacter();
    }


    public void StoreArmWidthVal(){
        armWidthTextVal = armWidthInputField.GetComponent<Text>().text;
        armWidthNumberVal = int.Parse(armWidthTextVal, System.Globalization.NumberStyles.Integer);

        int integerLength = armWidthTextVal.Length;
        float armWidthChange = armWidthNumberVal * 0.01f;

        Debug.Log(armWidthNumberVal);

        if(dna == null){
                dna = avatar.GetDNA();
            }
        dna["forearmWidth"].Set(0.5f + armWidthChange);
            avatar.BuildCharacter();
    }


}
