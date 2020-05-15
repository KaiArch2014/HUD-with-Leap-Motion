using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI点击
/// </summary>
public class OnClick : MonoBehaviour
{
    /// <summary>
    /// 选中的UI
    /// </summary>
    public GameObject xuanZhongUI;
    public GameObject kongZhi;
    public void XuanZhe()
    {
        xuanZhongUI.SetActive(true);
    }

    public void QuXiao()
    {
        xuanZhongUI.SetActive(false);
    }
    /// <summary>
    /// 点击按钮时
    /// </summary>
    public void OnClickButton()
    {
        if (kongZhi == null)
        {
            Manager.manager.XuanZhe(this, gameObject);
        }
        else
        {
            Manager.manager.XuanZhe(this, kongZhi);
        }
            
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Manager.manager.buttons.Add(this);
        if (GetComponent<Button>()!=null)
        {
            GetComponent<Button>().onClick.AddListener(OnClickButton);
        }
        QuXiao();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
