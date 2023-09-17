using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class ClothingSelection : MonoBehaviour
{

    private DynamicCharacterAvatar avatar;
    // Start is called before the first frame update
    void Start()
    {
        avatar = GetComponent<DynamicCharacterAvatar>();
    }

    // Update is called once per frame
    void Update()
    {
        avatar.SetSlot("Chest", "FemaleShirt1");
        avatar.BuildCharacter();
        avatar.SetSlot("Legs", "FemalePants1");
        avatar.BuildCharacter();
    }
}
