using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject bookDisplay;
    public GameObject sceneDislay;
    public GameObject clueDislay;
    //public Button itemButton;
    //public GameObject allItems;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void test()
    {
        //NewItemManager.Instance.loadItemConfig();
        //GameObject go = GameObject.Instantiate(this.itemButton.gameObject, this.allItems.transform);
    }

    public void activeBook()
    {
        bookDisplay.SetActive(true);
    }

    public void disactiveBook()
    {
        bookDisplay.SetActive(false);
    }

    public void activeScene()
    {
        sceneDislay.SetActive(true);
    }

    public void disactiveScene()
    {
        sceneDislay.SetActive(false);
    }

    public void activeClue()
    {
        clueDislay.SetActive(true);
    }

    public void disactiveclue()
    {
        clueDislay.SetActive(false);
    }

    public void toHospital()
    {
        SceneManager.LoadScene(6);      
    }

    public void toDIDI()
    {
        SceneManager.LoadScene(5);
    }

    public void toLi()
    {
        SceneManager.LoadScene(3);
    }

    public void toDinnerHall()
    {
        SceneManager.LoadScene(1);
    }
    public void toBoss()
    {
        SceneManager.LoadScene(7);
    }
    public void toLab()
    {
        SceneManager.LoadScene(4);
    }

    public void toOver()
    {
        SceneManager.LoadScene(0);
    }
}
