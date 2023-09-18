using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circuit : MonoBehaviour
{
    public void EnterLabel()
    {
        transform.parent.GetComponent<Image>().color = Color.HSVToRGB(0.3f, 1, 1);
    }

    public void ExitLabel()
    {
        transform.parent.GetComponent<Image>().color = Color.HSVToRGB(0, 0, 0.3f);
    }
}
