using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BaslangicButonu()
    {
        // Ba�lang�� butonuna t�kland���nda oyun sahnesini y�kleyin
        SceneManager.LoadScene("Oyun");
    }

    public void CikisButonu()
    {
        // ��k�� butonuna t�kland���nda uygulamadan ��k�n
        Application.Quit();
    }
}
