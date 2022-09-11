using UnityEngine;
using UnityEngine.UI;

public class NameText : MonoBehaviour
{
    public Text TextName;
    public void SetName(string name) => TextName.text = name;
}
