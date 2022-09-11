using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHat : MonoBehaviour
{
    public List<GameObject> allHats = new List<GameObject>();

    public void Hat(int index)
    {
        for (int i = 0; i < allHats.Count; i++)
        {
            if(i == index)
            {
                allHats[i].SetActive(true);
            }
            else
            {
                allHats[i].SetActive(false);
            }
        }
    }
}
