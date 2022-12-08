using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float speed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
