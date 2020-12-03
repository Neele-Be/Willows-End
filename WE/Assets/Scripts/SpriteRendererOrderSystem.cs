using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererOrderSystem : MonoBehaviour
{
    [SerializeField]
    private int sortingOrdnerBase = 5000;
    [SerializeField]
    private int offset = 0;
    [SerializeField]
    private bool runOnlyOnce = false;
    private float timer;
    private float timerMax = .1f;

    private Renderer PositionRenderer;

    private void Awake()
    {
        PositionRenderer = gameObject.GetComponent<Renderer>();

        
    }

    private void LateUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = timerMax;
            PositionRenderer.sortingOrder = (int)(sortingOrdnerBase - transform.position.y - offset);
            if (runOnlyOnce)
            {
                Destroy(this);
            }
        }
    }
}
