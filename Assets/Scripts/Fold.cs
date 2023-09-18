using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fold : MonoBehaviour
{
    public GameObject _downpanel;
    public void ClickAbilities()
    {
        _downpanel.SetActive(!_downpanel.activeSelf);
    }
}
