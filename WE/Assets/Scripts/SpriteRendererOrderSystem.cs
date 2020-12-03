using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererOrderSystem : MonoBehaviour
{
    [SerializeField]
    private int sortingOrdnerBase = 5000;
    [SerializeField]
    private int offset = 0;
    private Renderer PositionRenderer;

    private void Awake()
    {
        PositionRenderer = gameObject.GetComponent<Renderer>();

        
    }

    private void LateUpdate()
    {
        PositionRenderer.sortingOrder = (int)(sortingOrdnerBase - transform.position.y - offset);
    }
}
