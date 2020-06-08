using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private MeshRenderer mat;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        BackgroundScroll();
    }
    private void BackgroundScroll()
    {
        Vector2 offset = mat.material.mainTextureOffset;
        offset.Set(0, offset.y + (speed * Time.deltaTime));
        mat.material.mainTextureOffset = offset;
    }
}
