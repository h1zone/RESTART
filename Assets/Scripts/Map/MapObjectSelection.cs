using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObjectSelection : MonoBehaviour
{
    [Header("Класс для выбора объекта на карте")]

    [Tooltip("Ссылки на меню Объекта")]
    public GameObject mapObjtMenu;

    void Start()
    {
        
    }


    // стандартная функция, нажатия на объект
    void OnMouseDown()
    {
        // Сохраняем как переменную - выбранный объект в статичной переменной всей сцены
        GlobalMap.selectedMapObj = this.gameObject;
        mapObjtMenu.SetActive(true); // показать меню объекта на карте
    }

    void Update()
    {
        
    }
}
