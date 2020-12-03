using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public static CursorController instance;

    public Texture2D pointer, look, speak, aim;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActivatePointer()
    {
        Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
    }


    public void ActivateLook()
    {
        Cursor.SetCursor(look, Vector2.zero, CursorMode.Auto);
    }

    public void ActivateSpeak()
    {
        Cursor.SetCursor(speak, Vector2.zero, CursorMode.Auto);
    }

    public void ActivateAim()
    {
        Cursor.SetCursor(aim, Vector2.zero, CursorMode.Auto);
    }
}
