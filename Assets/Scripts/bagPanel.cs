using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagPanel : MonoBehaviour
{
    //public Transform itemTemp;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public BagItemDetail bagItemDetail;


    public GameObject allItems;

    private List<GameObject> itemOBJList;
    private List<bagItem> bagItemList;
    public List<GameObject> buttonList;
    // Start is called before the first frame update    = GameObject.Find("GameObject/ChildGameObject")
    void Awake()
    {
        NewItemManager.Instance.loadItemConfig();
        this.bagItemList = NewItemManager.Instance.bagItemList;      
        /*this.itemOBJList = new List<GameObject>();
        this.itemOBJList.Add(itemButton.gameObject);
        for (int i = 0; i < 4; i++)
        {
            GameObject go = this.createItem();
            Text text = go.transform.Find("Text").GetComponent<Text>();
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        //this.createAllItem(bagItem.locationType.Boss);

        //this.Button1 = GameObject.Find("clueDisplay/right/list/allBtn/Button1");
        this.buttonList.Add(this.Button1);
        this.buttonList.Add(this.Button2);
        this.buttonList.Add(this.Button3);
        this.buttonList.Add(this.Button4);
        this.buttonList.Add(this.Button5);
        this.displayClue(bagItem.locationType.Boss);
    }

    public void displayClue(bagItem.locationType locate)
    {
        int btnIndex = 0;
        for (int i = 0; i < this.bagItemList.Count; i++)
        {
            if (this.bagItemList[i].locate != locate || this.bagItemList[i].isFind == 0) 
                continue;


            //赋值
            bagItemInfo info =  this.buttonList[btnIndex].GetComponent<bagItemInfo>();
            buttonList[btnIndex].SetActive(true);
            info.setData(this.bagItemList[i]);

            bagItem item = this.bagItemList[i];
            Button btn = this.buttonList[btnIndex].GetComponent<Button>();
            btn.onClick.AddListener(() => {
                this.bagItemDetail.setData(item);
                this.bagItemDetail.gameObject.SetActive(true);
            });

            btnIndex += 1;

        }
        while (btnIndex<5)
        {
            buttonList[btnIndex].SetActive(false);
            btnIndex += 1;
        }
    }

    /// <summary>
    /// 创建一个具体的item
    /// </summary>
    private void createItem()
    {
        //GameObject go = GameObject.Instantiate(this.itemButton.gameObject, this.allItems.transform);
        //return go;

    }

    public void createAllItem(bagItem.locationType locate)
    {
        for(int i = 0; i < this.bagItemList.Count; i++)
        {
            if (this.bagItemList[i].locate != locate) continue;

            {
                GameObject go = null;
                Text text = go.transform.Find("Text").GetComponent<Text>();
                text.text = this.bagItemList[i].name;
            }
            
        }

    }



    public void hospitalClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.displayClue(bagItem.locationType.Hospital);
    }
    public void bossClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.displayClue(bagItem.locationType.Boss);

    }
    public void hallClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.displayClue(bagItem.locationType.Hall);

    }
    public void DiClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.displayClue(bagItem.locationType.Brother);

    }
    public void LiClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.displayClue(bagItem.locationType.Li);

    }
    public void labClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.displayClue(bagItem.locationType.Lab);

    }
}
