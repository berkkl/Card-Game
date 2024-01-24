using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExampleUI : MonoBehaviour
{
    public Image image;
    
    public void UpdateToBlue(){
        image.color = Color.blue;
    }

    public void UpdateToRed()
    {
        image.color = Color.red;
    }
}
