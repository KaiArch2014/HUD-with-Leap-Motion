using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 切换
/// </summary>
public class Cut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject game;
   public void OnClick()
    {
        game.SetActive(!game.activeSelf);
        Invoke("yanChi", 0.1f);
    }
    public void yanChi()
    {
        if (!game.activeSelf&& GetComponent<OnClick>()!=null)//如果是关闭
        {
            Manager.manager.record = null;
            Manager.manager.recordObject = null;
            GetComponent<OnClick>().xuanZhongUI.SetActive(false);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
