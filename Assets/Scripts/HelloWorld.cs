using System;
using UnityEngine;
using Unity;
using UnityEngine.Serialization;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [FormerlySerializedAs("_speed")] [Range(0f, 100f)] [SerializeField] private float value = 30f;

    private string _startMessage = "";
    
    private void Awake()
    {
        DoStartFunction();
    }

    private void DoStartFunction()
    {
        if (prefab != null)
        {
            _startMessage += $"GameObject: {prefab.name} selected \n";
        }
        _startMessage += $"Value: {value} \n";
        Debug.Log(_startMessage);
    }
}
