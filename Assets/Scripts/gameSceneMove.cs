using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSceneMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f,distancePer;

    private Transform tm;
    public GameObject obstacle;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }

    private void Awake()
    {
        tm = GetComponent<Transform>();
    }
}