using UnityEngine;
using UnityEngine.UI;

public class cansayar : MonoBehaviour
{
    public can can ;
    private Text canMetni;

    private void Start()
    {
        canMetni = GetComponent<Text>();
        UpdateCanMetni();
    }

    private void UpdateCanMetni()
    {
        canMetni.text = "Can: " +can.GetCurrentCan().ToString();
    }

    private void Update()
    {
        UpdateCanMetni();
    }
}
