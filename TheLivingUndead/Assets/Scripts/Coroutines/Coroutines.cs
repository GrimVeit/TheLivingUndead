using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    private static Coroutines instance
    {
        get
        {
            if (m_instance == null)
            {
                var go = new GameObject("[COROUTINE MANAGER]");
                m_instance = go.AddComponent<Coroutines>();
                DontDestroyOnLoad(go);
            }
            return m_instance;
        }
    }

    private static Coroutines m_instance;

    public static Coroutine StartRoutine(IEnumerator enumerator)
    {
        return instance.StartCoroutine(enumerator);
    }

    public static void StopRoutine(Coroutine coroutine)
    {
        instance.StopCoroutine(coroutine);
    }

    public static void StartCoroutine_(IEnumerator enumerator)
    {
        instance.StartCoroutine(enumerator);
    }

    public static void StopCoroutine_(IEnumerator enumerator)
    {
        instance.StopCoroutine(enumerator);
    }
}
