using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class upgradebusiness: MonoBehaviour
    
{
    int scraps;
    public Text scrapsText;
    public Button upgradeButton;
    // Start is called before the first frame update
    void Start()
    {
        scraps = int.Parse(scrapsText.text);        
    }

    // Update is called once per frame
    void Update()
    {
        scrapsText.text = "Scraps: \n" + scraps.ToString();
        
        if (scraps>= 500)
            upgradeButton.interactable= true; 
        else
            upgradeButton.interactable= false;       
    }
    public void buyUpgrade ()
    {
        scraps=scraps-100;
        scrapsText.text= scraps.ToString();
    }
    public void resetUpgrade()
    {
        scraps= 450;
        scrapsText.text = "Scraps:\n" + scraps.ToString();
    }
}
