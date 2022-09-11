using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snowman : MonoBehaviour
{
    public Slider slider;
    public List<Renderer> SnowmanBalls = new List<Renderer>(); 

    void Start() => slider.value = transform.localScale.y;
    public void SetScale(float value) => transform.localScale = new Vector3(value, value, value);
    public void SetMaterial(Material material)
    {
        for (int i = 0; i < SnowmanBalls.Count; i++)
        {
            SnowmanBalls[i].material = material;
        }
    }
}
