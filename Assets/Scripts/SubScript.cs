using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SpeechLib;

public class SubScript : MonoBehaviour
{
    public GameObject textBox;
    public bool subDec = true;
    public GameObject buttonText;

    private SpVoice voice;

    void Start()
    {
        voice = new SpVoice();
        voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
        voice.Rate = 2;
        voice.Volume = 100;
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "测试字幕，字幕功能可用！可以正常显示字幕！！！";
        voice.Speak("测试字幕，字幕功能可用！可以正常显示字幕！！！", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        yield return new WaitForSeconds(7);
        textBox.GetComponent<Text>().text = "现场布置安全措施，在作业区域挂指示牌，同时工作负责人核实安全措施是否完善。。。";
        voice.Speak("现场布置安全措施，在作业区域挂指示牌，同时工作负责人核实安全措施是否完善。。。", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        yield return new WaitForSeconds(8);
        textBox.GetComponent<Text>().text = "布置好安全措施后，工作负责人电话通知工作许可人及相关人员，申请开工。。。";
        voice.Speak("布置好安全措施后，工作负责人电话通知工作许可人及相关人员，申请开工。。。", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        yield return new WaitForSeconds(8);
        textBox.GetComponent<Text>().text = "到达现场后，工作负责人对工作环境进行详细勘查。检查带电运行设备与工作区域安全距离是否满足《安规》中的要求；工具、设备进入工作区域的通道是否畅通。。。";
        voice.Speak("到达现场后，工作负责人对工作环境进行详细勘查。检查带电运行设备与工作区域安全距离是否满足《安规》中的要求；工具、设备进入工作区域的通道是否畅通。。。", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        yield return new WaitForSeconds(3);
    }

    public void switchSubs()
    {
        if (subDec == false)
        {
            textBox.SetActive(true);
            subDec = true;
            buttonText.GetComponent<Text>().text = "关闭字幕";
            return;
        }
        if (subDec == true)
        {
            textBox.SetActive(false);
            subDec = false;
            buttonText.GetComponent<Text>().text = "打开字幕";
            return;
        }
    }
}
