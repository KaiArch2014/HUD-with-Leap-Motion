using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class GrammerRecognizerBehaviour : MonoBehaviour
{
    GrammarRecognizer grammerRecognizer;
    public GameObject m_interface;
    // Use this for initialization
    void Start()
    {
        // pass path of your grammar XML in the constructor
        print(Application.streamingAssetsPath + "/SRGS/myGrammar.xml");
        grammerRecognizer = new GrammarRecognizer(Application.streamingAssetsPath + "/SRGS/myGrammar.xml");
        grammerRecognizer.OnPhraseRecognized += OnGrammerRecognized;
        grammerRecognizer.Start();
    }

    void OnGrammerRecognized(PhraseRecognizedEventArgs args)
    {
        // write your own logic
        print(args.text);
        print("gadfa");
        if (args.text=="interface off"|| args.text == "头显 off")//开启抬头显示
        {
            m_interface.SetActive(false);
        }
        else if (args.text == "interface on"|| args.text == "头显 on")//关闭抬头显示
        {
            m_interface.SetActive(true);
        }

        if (args.text == "dashboard off")//仪表板显示
        {
            dashboard.SetActive(false);
        }
        else if (args.text == "dashboard on")//仪表盘显示
        {
            dashboard.SetActive(true);
        }

        if (args.text == "navigation off")//导航显示
        {
            navigation.SetActive(false);
        }
        else if (args.text == "navigation on")//导航显示
        {
            navigation.SetActive(true);
        }

        if (args.text == "call off")//视频电话显示
        {
            call.SetActive(false);
        }
        else if (args.text == "call on")//视频电话显示
        {
            call.SetActive(true);
        }

        if (args.text == "message off")//短信显示
        {
            message.SetActive(false);
        }
        else if (args.text == "message on")//短信显示
        {
            message.SetActive(true);
        }
    }
    /// <summary>
    /// 仪表盘
    /// </summary>
    public GameObject dashboard;
    /// <summary>
    /// 导航
    /// </summary>
    public GameObject navigation;
    /// <summary>
    /// 电话
    /// </summary>
    public GameObject call;
    /// <summary>
    /// 短信
    /// </summary>
    public GameObject message;
    private void OnDestroy()
    {
        //判断场景中是否存在语音识别器，如果有，释放
        if (grammerRecognizer != null)
        {
            //用完应该释放，否则会带来额外的开销
            grammerRecognizer.Dispose();
        }

    }
}
