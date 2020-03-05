using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Класс обрабатывает предыдущее время выхода и текущее время входа
public class CheckTime : MonoBehaviour
{
    private void Awake()
    {
        var dateTime = DateTime.Now;
        Debug.Log("Время запуска: " + dateTime);

        CheckOffline();
    }


    // Метод отвечает за офлайн время 
    // получение разницы во времени (с помощтью струтуры TimeSpan)
    // Если значение существует
    private void CheckOffline()
    {
        TimeSpan ts;

        if (PlayerPrefs.HasKey("LastSessionExit"))
        {
            ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSessionExit"));

            Debug.Log("Предыдущее время выхода: " + PlayerPrefs.GetString("LastSessionExit"));
            Debug.Log("Отсутствие: " + ts);
        }
    }


    // Метод нормального выхода, если нажата кнопка выхода
    private void OnApplicationQuit()
    {
        SaveLastSessionTime();
    }


    // (Андроид) Метод при выходе игры через сворачивание 
    // Если приложение было поставлено на паузу -> сохранить время
    private void OnApplicationPause(bool pause)
    {
        if (pause) SaveLastSessionTime();
    }

    // Метод сохранения время выхода из игры
    private void SaveLastSessionTime()
    {
        PlayerPrefs.SetString("LastSessionExit", DateTime.Now.ToString());
    }
}
