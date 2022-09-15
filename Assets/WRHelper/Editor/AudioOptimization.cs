using System;
using System.Diagnostics;
using System.IO;
using UnityEditor;

public class AudioOptimization
{
    [MenuItem("WRTools/Audio优化")]
    public static void AudioOpt()
    {
        // 点击ok返回true，点击cancel返回false；
        bool res = EditorUtility.DisplayDialog("Audio优化", "是否打开py文件", "好的", "哒咩");
        if (res)
        {
            OptimizationHelper.OpenFile(OptimizationHelper.GetInstance().AudioOptPy);
        }
        
    }
}