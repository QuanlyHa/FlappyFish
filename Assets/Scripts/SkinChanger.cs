using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    [Header("Karakter Sprite Renderer")]
    public SpriteRenderer playerRenderer;

    [Header("Tüm Skinler")]
    public Sprite[] skins;

    private const string skinKey = "SelectedSkin";

    private void Start()
    {
        // Kaydedilmiþ skin varsa uygula
        int savedSkin = PlayerPrefs.GetInt(skinKey, 0);
        ApplySkin(savedSkin);
    }

    public void ChangeSkin(int skinIndex)
    {
        ApplySkin(skinIndex);

        // Seçimi kaydet
        PlayerPrefs.SetInt(skinKey, skinIndex);
        PlayerPrefs.Save();

        //Debug.Log("Skin seçildi: " + skins[skinIndex].name);
    }

    private void ApplySkin(int skinIndex)
    {
        if (skinIndex >= 0 && skinIndex < skins.Length)
        {
            playerRenderer.sprite = skins[skinIndex];
        }
        else
        {
            Debug.LogWarning("Geçersiz skin indeksi!");
        }
    }
}
