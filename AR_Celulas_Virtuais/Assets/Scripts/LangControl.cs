using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LangControl : MonoBehaviour
{
    private int selectLocal;
    
    public void TrocaBandeira()
    {
        selectLocal = LocalizationSettings.AvailableLocales.Locales.IndexOf(LocalizationSettings.SelectedLocale);
        if (selectLocal == LocalizationSettings.AvailableLocales.Locales.Count - 1)
            selectLocal = 0;
        else selectLocal++;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[selectLocal];
    }
}
