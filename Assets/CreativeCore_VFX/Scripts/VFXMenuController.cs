using UnityEngine;

public class VFXMenuController : MonoBehaviour
{
    public GameObject settingsPanel; 
    public GameObject openMenuButton;

    public GameObject katanaVFXParent;
    public GameObject broadswordVFXParent;

    public void OpenMenu()
    {
        if (settingsPanel != null) settingsPanel.SetActive(true); 
        if (openMenuButton != null) openMenuButton.SetActive(false); 
    }

    public void CloseMenu()
    {
        if (settingsPanel != null) settingsPanel.SetActive(false); 
        if (openMenuButton != null) openMenuButton.SetActive(true); 
    }

    public void ToggleKatana(bool isOn)
    {
        if (katanaVFXParent != null) katanaVFXParent.SetActive(isOn);
    }

    public void ToggleBroadsword(bool isOn)
    {
        if (broadswordVFXParent != null) broadswordVFXParent.SetActive(isOn);
    }
}