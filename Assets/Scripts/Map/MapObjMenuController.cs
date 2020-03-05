using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MapObjMenuController : MonoBehaviour
{
  

    [Tooltip("Ссылки на меню Объекта")]
    public GameObject mapObjtMenu;

    void Start()
    {
      
    }




    public void BtnYesClick()
    {
        mapObjtMenu.gameObject.SetActive(false);
    }

    public void BtnNoClick()
    {
        mapObjtMenu.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
