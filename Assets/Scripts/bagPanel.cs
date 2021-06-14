using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagPanel : MonoBehaviour
{
    //public Transform itemTemp;
    public Button itemButton;
    public GameObject allItems;

    private List<GameObject> itemOBJList;
    private List<bagItem> bagItemList;
    // Start is called before the first frame update
    void Awake()
    {
        NewItemManager.Instance.loadItemConfig();
        this.bagItemList = NewItemManager.Instance.bagItemList;
        this.itemOBJList = new List<GameObject>();
        this.itemOBJList.Add(itemButton.gameObject);
        for (int i = 0; i < 4; i++)
        {
            GameObject go = this.createItem();
            Text text = go.transform.Find("Text").GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        //this.createAllItem(bagItem.locationType.Boss);
    }

    /// <summary>
    /// 创建一个具体的item
    /// </summary>
    private GameObject createItem()
    {
        GameObject go = GameObject.Instantiate(this.itemButton.gameObject, this.allItems.transform);
        return go;

    }

    public void createAllItem(bagItem.locationType locate)
    {
        for(int i = 0; i < this.bagItemList.Count; i++)
        {
            if (this.bagItemList[i].locate != locate) continue;

            {
                GameObject go = this.createItem();
                Text text = go.transform.Find("Text").GetComponent<Text>();
                text.text = this.bagItemList[i].name;
            }
            
        }

    }

    public void hospitalClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.createAllItem(bagItem.locationType.Hospital);
    }
    public void bossClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.createAllItem(bagItem.locationType.Boss);

    }
    public void hallClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.createAllItem(bagItem.locationType.Hall);

    }
    public void DiClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.createAllItem(bagItem.locationType.Brother);

    }
    public void LiClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.createAllItem(bagItem.locationType.Li);

    }
    public void labClicked(Toggle t)
    {
        if (!t.isOn) return;
        this.createAllItem(bagItem.locationType.Lab);

    }
}
