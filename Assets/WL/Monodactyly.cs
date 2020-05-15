using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单指选着
/// </summary>
public class Monodactyly : GestureBase
{
    public EHand m_Hand;

    public GameObject game;

    FingerExtendedDetails m_GestureDetail;

    void Start()
    {
        m_GestureDetail.bThumbExtended = true;
        m_GestureDetail.bIndexExtended = true;
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

    public void UpdateData()
    {
        game.SetActive(true);
        DetectionManager.DetectionHand detectHand_R = DetectionManager.Get().GetHand(EHand.eRightHand);
        game.transform.position = detectHand_R.GetFinger(EFinger.eIndex).GetTipPosition();
    }

    public void Ent()
    {
        game.SetActive(false);
    }
}
