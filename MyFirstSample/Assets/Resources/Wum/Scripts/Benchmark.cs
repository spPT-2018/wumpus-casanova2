using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Testing;
using UnityEngine;
using UnityEngine.UI;

public class Benchmark : MonoBehaviour {
    private StreamWriter LogFile;
    private string mode;
    private AllTests tests;

    public void OpenLogFile(string filename)
    {
        var curDir = Directory.GetCurrentDirectory();
        Debug.Log(curDir);
        string fullPath;
        if(Application.isEditor)
            fullPath = $"{curDir}/../results/{filename}";
        else
            fullPath = $"{curDir}/../../results/{filename}";

        if (File.Exists(fullPath))
        {
            Debug.Log("Deleting old result file");
            File.Delete(fullPath);
        }

        LogFile = new StreamWriter(fullPath);

        LogFile.WriteLine("Test,Mean,Deviation,Count");
    }

    public void CloseLogFile()
    {
        LogFile.Flush();
        LogFile.Close();
    }

    void Start()
    {
        tests = new AllTests();
        if (Application.isEditor)
            mode = "editor";
        else
            mode = "release";
        OpenLogFile($"Unity C# ({mode}).csv");
    }

    private void OnDestroy()
    {
        CloseLogFile();
    }


    public double Mark8(string msg, Action<float, BMark> fun,
            int iterations, double minTime)
    {
        int count = 1, totalCount = 0;
        double dummy = 0.0, runningTime = 0.0, deltaTime = 0.0, deltaTimeSquared = 0.0;
        do
        {
            count *= 2;
            deltaTime = 0.0;
            deltaTimeSquared = 0.0;
            for (int j = 0; j < iterations; j++)
            {
                Timer t = new Timer();
                for (int i = 0; i < count; i++)
                {
                    fun(i, null);
                    dummy += tests.Rf;
                }
                runningTime = t.Check();
                double time = runningTime / count;
                deltaTime += time;
                deltaTimeSquared += time * time;
                totalCount += count;
            }
        } while (runningTime < minTime && count < Int32.MaxValue / 2);

        double mean = deltaTime / iterations,
            standardDeviation = Math.Sqrt((deltaTimeSquared - mean * mean * iterations) / (iterations - 1));
        LogFile.WriteLine($"{msg},{mean},{standardDeviation},{count}");
        return dummy / totalCount;
    }

    bool testRun = false;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !testRun)
        {
            testRun = true;

            Mark8("ScaleVector2D", tests.Rule0, 5, MsToNs(250));
            Mark8("ScaleVector3D", tests.Rule6, 5, MsToNs(250));
            Mark8("Multiply2D", tests.Rule1, 5, MsToNs(250));
            Mark8("Multiply3D", tests.Rule7, 5, MsToNs(250));
            Mark8("TranslateVector2D", tests.Rule2, 5, MsToNs(250));
            Mark8("TranslateVector3D", tests.Rule8, 5, MsToNs(250));
            Mark8("SubtractVector2D", tests.Rule3, 5, MsToNs(250));
            Mark8("SubtractVector3D", tests.Rule9, 5, MsToNs(250));
            Mark8("LengthVector2D", tests.Rule4, 5, MsToNs(250));
            Mark8("LengthVector3D", tests.Rule10, 5, MsToNs(250));
            Mark8("Dotproduct2D", tests.Rule5, 5, MsToNs(250));
            Mark8("Dotproduct3D", tests.Rule11, 5, MsToNs(250));
            Mark8("Sestoft", tests.Rule12, 5, MsToNs(250));

            Debug.Log("Tests done");
        }
    }

    static double MsToNs(long ms) => ms * 1000000D;
}
