using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class HelloWorld
{
    [MenuItem("WRTools/Test/一个没得感情的Cube")]
    private static void CreateCube()
    {
        // 点击ok返回true，点击cancel返回false；
        bool res = EditorUtility.DisplayDialog("一个没得感情的Cube", "是否创建一个Cube", "好的", "哒咩");
        if (res)
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);
            
        }
    }
}