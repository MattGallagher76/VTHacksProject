using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class ClothingSelection : MonoBehaviour
{

    private DynamicCharacterAvatar avatar;

    public Canvas shirtOptions;
    public Canvas shirtColors;
    private string shirtType;
    private Color yellow;

    private bool clearShirt = false;
    private bool clearPants = false;
    private bool clearShoes = false;
    private int i = 0;

private bool shirtYellow = false;
    // Start is called before the first frame update
    void Start()
    {
     yellow = new Color(0f, 0.19f, 0.69f, 0.12f);
        avatar = GetComponent<DynamicCharacterAvatar>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(i == 0){
            avatar.SetSlot("Chest", "FemaleShirt2");
            avatar.BuildCharacter();
            avatar.SetSlot("Legs", "FemalePants1");
            avatar.BuildCharacter();
            i++;

        }

    }

    public void changeClothes(string part, string article, string name, Color color ){


        avatar.ClearSlot("Chest");
        avatar.BuildCharacter();
        avatar.SetSlot("Chest", "FemaleShirt1");
            avatar.BuildCharacter();
            avatar.SetSlot("Legs", "FemalePants1");
            avatar.BuildCharacter();
        
        shirtYellow = false;
    }

      public void clickShirt1(){
        shirtOptions.gameObject.SetActive(false);
        shirtColors.gameObject.SetActive(true);

        shirtType = "FemaleShirt1";
        /*
        avatar.ClearSlot("Chest");
        avatar.BuildCharacter();
        avatar.SetSlot("Chest", "FemaleShirt1");
        avatar.BuildCharacter();
        */

    }
     public void shirtColorYellowClick(){
        shirtColors.gameObject.SetActive(false);

       clearShirt = true;


    }

    public void setClearShirt(){
        clearShirt = true;
    }
}
