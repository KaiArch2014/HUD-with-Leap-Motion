using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 管理员
/// </summary>
public class Manager : MonoBehaviour
{
    /// <summary>
    /// 所有的按钮
    /// </summary>
    public List<OnClick> buttons = new List<OnClick>();
    /// <summary>
    /// 记录当前选着的按钮
    /// </summary>
    public OnClick record;
    /// <summary>
    ///记录需要控制的对象
    /// </summary>
    public GameObject recordObject;

    public ResizeObject resizeObject;
    public TranslateObject translateObject;
    public static Manager manager;
    public void Awake()
    {
        manager = this;
    }
    void Start()
    {
        
    }

    public void XuanZhe(OnClick game,GameObject @object)
    {
        foreach (var item in buttons)
        {
            item.QuXiao();
        }
        if (game== record)
        {
            record = null;
            recordObject = null;
        }
        else
        {
            record = game;
            recordObject = @object;
            game.XuanZhe();
        }
    }
    public void QuXiao()
    {
        foreach (var item in buttons)
        {
            item.QuXiao();
        }
        record = null;
    }
    void Update()
    {
        resizeObject.m_object = recordObject;
        translateObject.m_object = recordObject;
    }
}
