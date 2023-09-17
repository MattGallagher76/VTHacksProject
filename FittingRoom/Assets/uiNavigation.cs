using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UMA;
using UMA.CharacterSystem;
public class uiNavigation : MonoBehaviour
{
    public Canvas uiCanvas;
    public Canvas collarCanvas;
    public Canvas waistCanvas;
    public Canvas hipCanvas;
    public Canvas torsoCanvas;
    public Canvas chestCanvas;
    public Canvas shoulderCanvas;
    public Canvas armLengthCanvas;
    public Canvas armWidthCanvas;

    public Canvas clothesCanvas;

    public Canvas maleOrFemalCanvas;

    public Canvas menuBar;
       public Canvas clothesBar;

    public Canvas shirtColors;
    public Canvas pantsColors;
    public Canvas shoeColors;

      public Canvas shirtOptions;
    public Canvas pantsOptions;
    public Canvas shoeOptions;

    public Button activateMenuButton;
     public Button activateClothesMenuButton;
    public Button volumeOnButton;
    public Button volumeOffButton;
    public Button clothesToggleInactiveButton;


    public GameObject music;   
    public GameObject woman;
   
   private DynamicCharacterAvatar avatar;

   private ClothingSelection cs;

   private Color red;
   private Color orange;
   private Color yellow;
   private Color green;
   private Color blue;
   private Color indigo;
   private Color violet;



    // Start is called before the first frame update
    void Start()
    {
        
        avatar = woman.GetComponent<DynamicCharacterAvatar>();
        
        red = Color.red;
        orange = new Color(0f, 0.31f, 0.53f, 0.16f);
        yellow = Color.yellow;
        green = Color.green;
        blue = Color.blue;
        indigo = new Color(0.31f, 0f, 0f, 0.11f);
        violet = new Color (0.21f, 0.73f, 0f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateMenu(){
        menuBar.gameObject.SetActive(true);
        activateMenuButton.gameObject.SetActive(false);
    }

    public void activateClothesMenu(){
        clothesBar.gameObject.SetActive(true);
        activateClothesMenuButton.gameObject.SetActive(false);
    }

    public void deactivateMenu(){
        menuBar.gameObject.SetActive(false);
        activateMenuButton.gameObject.SetActive(true);
    }

    public void deactivateClothesMenu(){
        clothesBar.gameObject.SetActive(false);
        activateClothesMenuButton.gameObject.SetActive(true);
    }


    public void collarClick(){
        menuBar.gameObject.SetActive(false);
        collarCanvas.gameObject.SetActive(true);
    }


    public void doneCollar(){
        collarCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void waistClick(){
        menuBar.gameObject.SetActive(false);
        waistCanvas.gameObject.SetActive(true);
    }


    public void doneWaist(){
        waistCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void hipClick(){
        menuBar.gameObject.SetActive(false);
        hipCanvas.gameObject.SetActive(true);
    }


    public void doneHip(){
        hipCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void chestClick(){
        menuBar.gameObject.SetActive(false);
        chestCanvas.gameObject.SetActive(true);
    }


    public void doneChest(){
        chestCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void torsoClick(){
        menuBar.gameObject.SetActive(false);
        torsoCanvas.gameObject.SetActive(true);
    }


    public void doneTorso(){
        torsoCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void shoulderClick(){
        menuBar.gameObject.SetActive(false);
        shoulderCanvas.gameObject.SetActive(true);
    }


    public void doneShoulder(){
        shoulderCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void armLengthClick(){
        menuBar.gameObject.SetActive(false);
        armLengthCanvas.gameObject.SetActive(true);
    }


    public void doneArmLength(){
        armLengthCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void armWidthClick(){
        menuBar.gameObject.SetActive(false);
        armWidthCanvas.gameObject.SetActive(true);
    }


    public void doneArmWidth(){
        armWidthCanvas.gameObject.SetActive(false);
        menuBar.gameObject.SetActive(true);

    }

    public void genderClick(){
        maleOrFemalCanvas.gameObject.SetActive(false);
        activateMenuButton.gameObject.SetActive(true);

    }

    public void volumeOnClick(){
        volumeOnButton.gameObject.SetActive(false);
        volumeOffButton.gameObject.SetActive(true);

        music.GetComponent<AudioSource>().mute = true;

        
    }
     public void volumeOffClick(){
        volumeOnButton.gameObject.SetActive(true);
        volumeOffButton.gameObject.SetActive(false);

        music.GetComponent<AudioSource>().mute = false;
    }

    public void completeMeasurementsClick(){
       
        menuBar.gameObject.SetActive(false);
        activateClothesMenuButton.gameObject.SetActive(true);

    }

    public void shirtButtonClick(){
        shirtOptions.gameObject.SetActive(true);
    }

    public void shirtColorRedClick(){
        shirtColors.gameObject.SetActive(false);
        
        avatar.SetColor("Shirt", red);
        avatar.BuildCharacter();
    }
    public void shirtColorOrangeClick(){
        shirtColors.gameObject.SetActive(false);

       avatar.SetColor("Shirt", orange);
        avatar.BuildCharacter();
    }
    public void shirtColorYellowClick(){
       shirtColors.gameObject.SetActive(false);

       avatar.SetColor("Shirt", yellow);
        avatar.BuildCharacter();


    }
    public void shirtColorGreenClick(){
        shirtColors.gameObject.SetActive(false);

        avatar.SetColor("Shirt", green);
        avatar.BuildCharacter();
    }
    public void shirtColorBlueClick(){
        shirtColors.gameObject.SetActive(false);

        avatar.SetColor("Shirt", blue);
        avatar.BuildCharacter();
    }
    public void shirtColorIndigoClick(){
        shirtColors.gameObject.SetActive(false);

        avatar.SetColor("Shirt", indigo);
        avatar.BuildCharacter();
    }
    public void shirtColorVioletClick(){
        shirtColors.gameObject.SetActive(false);

        avatar.SetColor("Shirt", violet);
        avatar.BuildCharacter();
    }



    public void pantsButtonClick(){
        pantsOptions.gameObject.SetActive(true);
    }

    public void pantsColorRedClick(){
        pantsColors.gameObject.SetActive(false);

        avatar.SetColor("Pants1", red);
        avatar.BuildCharacter();
    }
    public void pantsColorOrangeClick(){
        pantsColors.gameObject.SetActive(false);

        avatar.SetColor("Pants1", orange);
        avatar.BuildCharacter();
    }
    public void pantsColorYellowClick(){
        pantsColors.gameObject.SetActive(false);

        avatar.SetColor("Pants1", yellow);
        avatar.BuildCharacter();
    }
    public void pantsColorGreenClick(){
        pantsColors.gameObject.SetActive(false);

        avatar.SetColor("Pants1", green);
        avatar.BuildCharacter();
    }
    public void pantsColorBlueClick(){
        pantsColors.gameObject.SetActive(false);

        avatar.SetColor("Pants1", blue);
        avatar.BuildCharacter();
    }
    public void pantsColorIndigoClick(){
        pantsColors.gameObject.SetActive(false);

        avatar.SetColor("Pants1", indigo);
        avatar.BuildCharacter();
    }
    public void pantsColorVioletClick(){
        pantsColors.gameObject.SetActive(false);

        avatar.SetColor("Pants1", violet);
        avatar.BuildCharacter();
    }





    public void shoeButtonClick(){
        shoeOptions.gameObject.SetActive(true);

        
    }

    public void shoeColorRedClick(){
        shoeColors.gameObject.SetActive(false);
        
        avatar.SetColor("Shoes", red);
        avatar.BuildCharacter();
    }
    public void shoeColorOrangeClick(){
        shoeColors.gameObject.SetActive(false);

        
        
        avatar.SetColor("Shoes", orange);
        avatar.BuildCharacter();
    }
    public void shoeColorYellowClick(){
        shoeColors.gameObject.SetActive(false);

        
        
        avatar.SetColor("Shoes", yellow);
        avatar.BuildCharacter();

        
    }
    public void shoeColorGreenClick(){
        shoeColors.gameObject.SetActive(false);

        
        
        avatar.SetColor("Shoes", green);
        avatar.BuildCharacter();
    }
    public void shoeColorBlueClick(){
        shoeColors.gameObject.SetActive(false);

        
        avatar.SetColor("Shoes", blue);
        avatar.BuildCharacter();
    }
    public void shoeColorIndigoClick(){
        shoeColors.gameObject.SetActive(false);

        
        avatar.SetColor("Shoes", indigo);
        avatar.BuildCharacter();
    }
    public void shoeColorVioletClick(){
        shoeColors.gameObject.SetActive(false);

        avatar.SetColor("Shoes", violet);
        avatar.BuildCharacter();
    }


    public void makeWomanAppear(){
        woman.SetActive(true);
    }


    public void clickShirt1(){
        shirtOptions.gameObject.SetActive(false);
        shirtColors.gameObject.SetActive(true);
        
        avatar.ClearSlot("Chest");
        avatar.BuildCharacter();
        avatar.SetSlot("Chest", "FemaleShirt1");
        avatar.BuildCharacter();
        

    }
    public void clickShirt2(){
         shirtOptions.gameObject.SetActive(false);
        shirtColors.gameObject.SetActive(true); 

        avatar.ClearSlot("Chest");
        avatar.BuildCharacter();
        avatar.SetSlot("Chest", "FemaleShirt2");
        avatar.BuildCharacter();
    }

    public void clickShirt3(){
         shirtOptions.gameObject.SetActive(false);
        shirtColors.gameObject.SetActive(true); 

        avatar.ClearSlot("Chest");
        avatar.BuildCharacter();
        avatar.SetSlot("Chest", "FemaleShirt4");
        avatar.BuildCharacter();
    }

    public void clickPants1(){
        pantsOptions.gameObject.SetActive(false);
        pantsColors.gameObject.SetActive(true); 

        avatar.ClearSlot("Legs");
        avatar.BuildCharacter();
        avatar.SetSlot("Legs", "FemalePants1");
        avatar.BuildCharacter();
    }

    public void clickPants2(){
        pantsOptions.gameObject.SetActive(false);
        pantsColors.gameObject.SetActive(true); 

        avatar.ClearSlot("Legs");
        avatar.BuildCharacter();
        avatar.SetSlot("Legs", "FemalePants2");
        avatar.BuildCharacter();
    }


    public void clickShoes1(){
        shoeOptions.gameObject.SetActive(false);
        shoeColors.gameObject.SetActive(true); 

        avatar.ClearSlot("Feet");
        avatar.BuildCharacter();
        avatar.SetSlot("Feet", "FemaleTallShoes_Black");
        avatar.BuildCharacter();
    }
    public void clickShoes2(){
        shoeOptions.gameObject.SetActive(false);
        shoeColors.gameObject.SetActive(true);

        avatar.ClearSlot("Feet");
        avatar.BuildCharacter();
        avatar.SetSlot("Feet", "FemaleTallShoes_White");
        avatar.BuildCharacter(); 
    }
}
