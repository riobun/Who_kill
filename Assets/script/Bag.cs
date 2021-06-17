 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    public Image _Message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        _Message.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
