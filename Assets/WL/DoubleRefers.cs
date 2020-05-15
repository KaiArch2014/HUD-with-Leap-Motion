using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 双指移动
/// </summary>
public class DoubleRefers : GestureBase
{
    public EHand m_Hand;

    FingerExtendedDetails m_GestureDetail;

    void Start()
    {
        m_GestureDetail.bThumbExtended = false;
        m_GestureDetail.bIndexExtended = true;
        m_GestureDetail.bMiddleExtended = true;
        m_GestureDetail.bRingExtended = false;
        m_GestureDetail.bPinkeyExtended = false;
      
    }

    void Update()
    {
      //  GetComponent<TranslateObject>().m_object = Manager.manager.recordObject;
    }

    public override bool Detected()
    {
        DetectionManager.DetectionHand detectHand = DetectionManager.Get().GetHand(m_Hand);
        if (!DetectionManager.Get().IsHandSet(m_Hand))
        {
            return false;
        }
        if (detectHand.IsSet())
        {
            return detectHand.CheckWithDetails(m_GestureDetail);
        }

        return false;
    }
}
