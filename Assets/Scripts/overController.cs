using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overController : MonoBehaviour
{
    public GameObject canvas;
    public Flowchart flowchart;

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("�鿴����"))
        {
            canvas.SetActive(true);
            flowchart.SetBooleanVariable("�鿴����", false);
        }
        if (flowchart.GetBooleanVariable("�˳���Ϸ"))
        {

            UnityEditor.EditorApplication.isPlaying = false;
            //Application.Quit();
            flowchart.SetBooleanVariable("�˳���Ϸ", false);
        }
    }
}
