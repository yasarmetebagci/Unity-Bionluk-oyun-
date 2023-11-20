using UnityEngine;
using UnityEngine.UI;

public class cointoplama : MonoBehaviour
{
    public paramęktar paramęktar;
    private Text paraMetni;

    private void Start()
    {
        paraMetni = GetComponent<Text>();
        UpdateParaMetni();
    }

    private void UpdateParaMetni()
    {
        paraMetni.text = "Para: " + paramęktar.GetParaMiktari().ToString();
    }

    private void Update()
    {
        UpdateParaMetni();
    }
}
