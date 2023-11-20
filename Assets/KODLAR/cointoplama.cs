using UnityEngine;
using UnityEngine.UI;

public class cointoplama : MonoBehaviour
{
    public paramýktar paramýktar;
    private Text paraMetni;

    private void Start()
    {
        paraMetni = GetComponent<Text>();
        UpdateParaMetni();
    }

    private void UpdateParaMetni()
    {
        paraMetni.text = "Para: " + paramýktar.GetParaMiktari().ToString();
    }

    private void Update()
    {
        UpdateParaMetni();
    }
}
