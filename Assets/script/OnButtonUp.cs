using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnButtonUp : MonoBehaviour
{

    public Image _Message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnBtnUp()
    {
        _Message.gameObject.SetActive(false);
        Debug.Log("OnButtonUp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
