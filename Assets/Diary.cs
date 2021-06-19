using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diary : MonoBehaviour
{
    public Image panel;
    public Text title;
    public Text detail;

    private List<string> clueInfo;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseDown()
    {
        //16����������id����Assets/config/item�ļ��в鿴ÿ��������id
        this.clueInfo = GameObject.Find("Canvas").GetComponent<GameUI>().findClue(5);
        this.title.text = this.clueInfo[0];
        this.detail.text = this.clueInfo[1];

        panel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
