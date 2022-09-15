using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class OptimizationHelper : BaseManager<OptimizationHelper>
{
    public string TextPath = "/Users/wankcn/Desktop/audio_txt";
    public string AudioOptPy = "/Users/wankcn/Desktop/Suntail_Village_Optimization/Assets/WRHelper/audio_optimize.py";
    private List<string> _paths;


    public List<string> ReadTxt(string path)
    {
        _paths = new List<string>();
        foreach (string line in File.ReadLines(path))
        {
            _paths.Add(line);
        }

        return _paths;
    }


    public static void OpenFile(string filePathAndName, bool isWaitFileClose = true)
    {
        Process process = new Process();
        ProcessStartInfo psi = new ProcessStartInfo(filePathAndName);
        process.StartInfo = psi;
        process.StartInfo.UseShellExecute = true;

        try
        {
            process.Start();
            //等待打开的程序关闭
            if (isWaitFileClose)
                process.WaitForExit();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            process?.Close();
        }
    }

    public void ClearData()
    {
        _paths.Clear();
    }
}