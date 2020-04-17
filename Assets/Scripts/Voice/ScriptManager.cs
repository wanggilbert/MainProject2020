using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScriptManager : MonoBehaviour
{
    public string resourceFile = "test";
    private Dictionary<string, string> lines = new Dictionary<string, string>(StringComparer .OrdinalIgnoreCase);

    public string GetText(string textkey)
    {
        string tmp = " ";
        if (lines.TryGetValue(textkey, out tmp))
            return tmp;

        return string.Empty;        
    }

    private void Awake()
    {
        var textAsset = Resources.Load<TextAsset>(resourceFile);
        var voTest = JsonUtility.FromJson<VoiceOverText>(textAsset.text);

        foreach (var t in voTest .lines)
        {
            lines[t.key] = t.line;
        }
    }
}
