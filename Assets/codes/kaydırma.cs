using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaydırma : MonoBehaviour
{
    [SerializeField] private float hiz = 3f;

    private float offset;

    private Material backgroundMaterial;
    void Start()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (hiz * Time.deltaTime);
        backgroundMaterial.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
