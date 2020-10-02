﻿using UnityEngine;
using System.Collections;

public class MonoTestCommand : MonoBehaviour
{
    void Start()
    {
        Saro.Terminal.Terminal.Shell.AddCommandInstance(typeof(MonoTestCommand), this);

        Debug.Log("<color=green>log info</color>");
        Debug.LogWarning("<color=yellow>log warning</color>");
        Debug.LogError("<color=red>log error</color>");
    }

    // instance method
    [Saro.Terminal.Command("print_vector3", "Print vector3 value")]
    public void Print(Vector3 v3)
    {
        print(v3);
    }

    // static method
    [Saro.Terminal.Command("print_int", "Print int value")]
    public static void Print(int v)
    {
        print(v);
    }

    [Saro.Terminal.Command("print_bool", "Print boolean value")]
    public static void Print(bool v)
    {
        print(v);
    }
}
