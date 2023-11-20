using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void BaslangicButonu()
    {
        // Baþlangýç butonuna týklandýðýnda oyun sahnesini yükleyin
        SceneManager.LoadScene("oyun");
    }

    public void CikisButonu()
    {
        // Çýkýþ butonuna týklandýðýnda uygulamadan çýkýn
        Application.Quit();
    }
}
