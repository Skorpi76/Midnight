using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager current;
    public Slider playerHealthBar;
    public Text weponAmmo;
    public Image weaponIcon;

    void Awake()
    {
        current = this;
    }
}
