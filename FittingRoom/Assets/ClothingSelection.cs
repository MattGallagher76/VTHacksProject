using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class ClothingSelection : MonoBehaviour
{

    private DynamicCharacterAvatar avatar;

    
    private int i = 0;

private bool shirtYellow = false;
    // Start is called before the first frame update
    void Start()
    {

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

  
}
