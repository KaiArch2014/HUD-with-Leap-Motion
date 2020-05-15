using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 亮度
/// </summary>
public class Luminance : MonoBehaviour
{
    public float x;
    public GameObject[]  games;
    public Image[] ii;
    public RawImage rawImage;
    public GameObject @object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = @object.transform.localPosition.y/50f;
        foreach (var item in games)
        {
            Image[] v= item.GetComponentsInChildren<Image>();
            foreach (var im in v)
            {
                im.color = new Color(im.color.r, im.color.g, im.color.b, x);
            }
            Text[] t = item.GetComponentsInChildren<Text>();
            foreach (var im in t)
            {
                im.color = new Color(im.color.r, im.color.g, im.color.b, x);
            }
        }
        foreach (var item in ii)
        {
            item.color = new Color(item.color.r, item.color.g, item.color.b, x);
        }
        rawImage.color = new Color(rawImage.color.r, rawImage.color.g, rawImage.color.b, x);
    }
}
