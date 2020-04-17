using UnityEngine;
using SpeechLib;

public class SpeechLibTest : MonoBehaviour
{
    public TextAsset textfile;
    //声明 SpVoice 对象
    SpVoice voice;
    void Start()
    {
        //实例化 SpVoice 对象
        voice = new SpVoice();
        //管理语音属性，注释掉的情况下下面也可以正常执行
        voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
        //语音速度，范围-10到10，默认是0
        voice.Rate = 2;
        //语音音量，范围0到100，默认是100
        voice.Volume = 100;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //同步朗读(同步朗读时系统会停在这里，直到朗读完毕才会往下执行，建议使用异步朗读)
            voice.Speak("语音测试");
            //异步朗读
            voice.Speak(textfile.text , SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            //暂停使用该对象的所有朗读进程，同步朗读下无法使用该方法暂停
            voice.Pause();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            //恢复该对象所对应的被暂停的朗读进程
            voice.Resume();
        }
    }
}

