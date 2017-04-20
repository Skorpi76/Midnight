using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager current;
    public Slider playerHealthBar;
    public Text weponAmmo;
    public Image weaponIcon;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;


    void Update()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameMenu");
            Exit.keyActive = false;
        }
    }

    void Awake()
    {
        current = this;
    }
  
}
