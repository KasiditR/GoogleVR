using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    public DisplayUI displayUI;
    public void Open(){
        displayUI.panel.SetActive(true);
        displayUI.GetData();
    }
    public void Exit(){
        displayUI.panel.SetActive(false);
    }
}
