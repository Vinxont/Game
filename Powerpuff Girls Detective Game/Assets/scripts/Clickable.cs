﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField] private GameObject objlock;
    [SerializeField] private GameObject objtext;
    bool anything = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        
        Debug.Log("on mouse down");
        //add the image 
        objlock.SetActive(!anything);
        objtext.SetActive(!anything);
        anything = !anything;

    }

    
}