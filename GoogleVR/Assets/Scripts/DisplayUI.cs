using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(OpenUI))]
public class DisplayUI : MonoBehaviour
{
    public GameObject panel;
    public TreeData treeData;
    public TMP_Text titel;
    public TMP_Text nameText;
    public TMP_Text detail;
    public Image img;
    public void GetData()
    {
        titel.text = treeData.titel;
        nameText.text = treeData.nameData;
        detail.text = treeData.detail;
        img.sprite = treeData.img;
    }

}
