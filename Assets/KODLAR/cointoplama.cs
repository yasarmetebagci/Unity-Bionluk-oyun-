using UnityEngine;
using UnityEngine.UI;

public class cointoplama : MonoBehaviour
{
    public param�ktar param�ktar;
    private Text paraMetni;

    private void Start()
    {
        paraMetni = GetComponent<Text>();
        UpdateParaMetni();
    }

    private void UpdateParaMetni()
    {
        paraMetni.text = "Para: " + param�ktar.GetParaMiktari().ToString();
    }

    private void Update()
    {
        UpdateParaMetni();
    }
}
