using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class upgrade : MonoBehaviour

{
    int beefsteak;
    public Text beefsteakText;
    public Button upgradeButton;
    // Start is called before the first frame update
    void Start()
    {
      beefsteak = int.Parse(beefsteakText.text);
    }

    // Update is called once per frame
    void Update()
    {
        beefsteakText.text = "Beefsteak: \n" + beefsteak.ToString();
        
        if (beefsteak>= 100)
            upgradeButton.interactable= true; 
        else
            upgradeButton.interactable= false;       
    }
    public void buyUpgrade ()
    {
        beefsteak=beefsteak-100;
        beefsteakText.text= beefsteak.ToString();
    }
    public void resetUpgrade()
    {
        beefsteak= 300;
        beefsteakText.text = "Beefsteak\n" + beefsteak.ToString();
    }
}
