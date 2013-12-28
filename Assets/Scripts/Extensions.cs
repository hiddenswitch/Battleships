using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public static class UnityExtensions
{
    public static T GetComponentInParents<T>(this Component behaviour)
        where T : Component
    {
        var parent = behaviour.transform.parent;
        T t = null;
        while (parent != null && (t = parent.gameObject.GetComponent<T>()) == null)
        {
            parent = parent.parent;
        }
        return t;
    }

    public static T GetComponentInParents<T>(this GameObject behaviour)
        where T : Component
    {
        var parent = behaviour.transform.parent;
        T t = null;
        while (parent != null && (t = parent.gameObject.GetComponent<T>()) == null)
        {
            parent = parent.parent;
        }
        return t;
    }
}