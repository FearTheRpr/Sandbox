using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; 



public class ColorChanger : MonoBehaviour
{
    public SteamVR_Action_Boolean ColorButton;
    public Renderer rend;
    private Material mat;
    public Color[] colors;
   public GameManager gameManager;
    


    // Start is called before the first frame update
    private void Start()
    {
        //rend = GetComponent<Renderer>();
        mat = rend.material;

        

        
    }
    //changes color when holding using a button press
    public void holding()
    {
     
            //creates an array to access random numbers/colors
            int randomNumber = Random.Range(0, colors.Length);

            gameManager.test = "Changed";
            Debug.Log(gameManager.test);
         

            //changes color to a random number of an array to select multiple colors based of unity input
            mat.SetColor("_Color", colors[randomNumber]);
      

        
    }

}
