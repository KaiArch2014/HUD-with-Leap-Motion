using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 界面控制
/// </summary>
public class Interface : GestureBase
{
    public EHand m_Hand;

    FingerExtendedDetails m_GestureDetail;

    void Start()
    {
        m_GestureDetail.bThumbExtended = false;
        m_GestureDetail.bIndexExtended = false;
        m_GestureDetail.bMiddleExtended = false;
        m_GestureDetail.bRingExtended = false;
        m_GestureDetail.bPinkeyExtended = false;
    }

    void Update()
    {
  
    }

    public override bool Detected()
    {
        DetectionManager.DetectionHand detectHand = DetectionManager.Get().GetHand(m_Hand);
    
        if (detectHand.IsSet())
        {
            return detectHand.CheckWithDetails(m_GestureDetail);
        }

        return false;
    }
    public GameObject maxUI;
    /// <summary>
    /// 显示隐藏控制
    /// </summary>
    public void ShowHide()
    {

        maxUI.SetActive(!maxUI.activeSelf);
    }

}
