using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{

    public int skinIndex; // Bu buton hangi skin için
    public SkinChanger skinChanger; // SkinChanger scripti referansý

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);

    }

    private void OnClick()
    {
        if (skinChanger != null)
        {
            skinChanger.ChangeSkin(skinIndex);
        }
    }



}
