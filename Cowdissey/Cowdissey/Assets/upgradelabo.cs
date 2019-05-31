using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class upgradelabo : MonoBehaviour
    
{
    int tubes;
    public Text tubesText;
    public Button upgradeButton;
    // Start is called before the first frame update
    void Start()
    {
        tubes = int.Parse(tubesText.text);        
    }

    // Update is called once per frame
    void Update()
    {
        tubesText.text = "Research points: \n" + tubes.ToString();
        
        if (tubes>= 100)
            upgradeButton.interactable= true; 
        else
            upgradeButton.interactable= false;       
    }
    public void buyUpgrade ()
    {
        tubes=tubes-100;
        tubesText.text= tubes.ToString();
    }
    public void resetUpgrade()
    {
        tubes= 1000;
        tubesText.text = "Research points:\n" + tubes.ToString();
    }
}
