using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LangControl : MonoBehaviour
{
    private int selectLocal;
    
    public void TrocaBandeira()
    {
        if (selectLocal == LocalizationSettings.AvailableLocales.Locales.Count - 1)
            selectLocal = 0;
        else selectLocal++;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[selectLocal];
    }
}
