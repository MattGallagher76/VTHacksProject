using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    public Button activateMenuButton;
     public Button activateClothesMenuButton;
    public Button volumeOnButton;
    public Button volumeOffButton;
    public Button clothesToggleInactiveButton;


    public GameObject music;   
    public GameObject woman;
   


    // Start is called before the first frame update
    void Start()
    {
        
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
        shirtColors.gameObject.SetActive(true);
    }

    public void shirtColorClick(){
        shirtColors.gameObject.SetActive(false);
    }

    public void pantsButtonClick(){
        pantsColors.gameObject.SetActive(true);
    }

    public void pantsColorClick(){
        pantsColors.gameObject.SetActive(false);
    }

    public void shoeButtonClick(){
        shoeColors.gameObject.SetActive(true);
    }

    public void shoeColorClick(){
        shoeColors.gameObject.SetActive(false);
    }

    public void makeWomanAppear(){
        woman.SetActive(true);
    }
}
