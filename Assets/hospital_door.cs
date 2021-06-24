using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class hospital_door : MonoBehaviour
{
    public GameObject labBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        
        LabManager.Instance.findlab = true;
        SceneManager.LoadScene(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
