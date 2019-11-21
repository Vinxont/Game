using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScale : MonoBehaviour
{[SerializeField] private Text input_text;
    [SerializeField] private GameObject cage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (input_text.text.Equals("8527")){
                Debug.Log("yessss");
                cage.gameObject.SetActive(false);
            }
            else Debug.Log("no");
            this.gameObject.SetActive(false);
        }
    }
}
