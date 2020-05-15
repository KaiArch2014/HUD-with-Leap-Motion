using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 限制
/// </summary>
public class XianZhi : MonoBehaviour
{
    float x;
    Vector3 si;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.localPosition.x;
        si = transform.localScale;
    }
    public float max_Y;
    public float min_Y;
    // Update is called once per frame
    void Update()
    {
        float y = transform.localPosition.y;
        if (y>= max_Y)
        {
            y = max_Y;
        }
        if (y<= min_Y)
        {
            y = min_Y;
        }
        transform.localPosition = new Vector3(x, y, 0);
        transform.localScale = si;
    }
}
