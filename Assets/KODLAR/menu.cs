using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BaslangicButonu()
    {
        // Baþlangýç butonuna týklandýðýnda oyun sahnesini yükleyin
        SceneManager.LoadScene("Oyun");
    }

    public void CikisButonu()
    {
        // Çýkýþ butonuna týklandýðýnda uygulamadan çýkýn
        Application.Quit();
    }
}
