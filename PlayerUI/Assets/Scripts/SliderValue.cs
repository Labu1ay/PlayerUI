using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public void SetText(float value) => GetComponent<Text>().text = value.ToString("0.00");
}
